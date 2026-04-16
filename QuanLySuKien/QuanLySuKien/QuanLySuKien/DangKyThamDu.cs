using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

// Fix for cancel registration feature

namespace QuanLySuKien
{
    public partial class DangKyThamDu : Form
    {
        public string MaSKDuocChon { get; set; } = "";
        public string TenSKDuocChon { get; set; } = "";
        public string MaNDK_Login { get; set; } = "";

        private readonly string connStr =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLySuKien;Integrated Security=True";

        private DataTable dtDanhSachTam = new DataTable();
        private int editingRow = -1;

        public DangKyThamDu()
        {
            InitializeComponent();
        }

        private void DangKyThamDu_Load(object sender, EventArgs e)
        {
            lblSubTitle.Text = $"Sự kiện: {MaSKDuocChon} – {TenSKDuocChon}";

            dtDanhSachTam.Columns.Clear();
            dtDanhSachTam.Columns.Add("HoTen");
            dtDanhSachTam.Columns.Add("NgaySinh", typeof(DateTime));
            dtDanhSachTam.Columns.Add("GioiTinh");
            dtDanhSachTam.Columns.Add("SDT");
            dtDanhSachTam.Columns.Add("Email");

            dgvDanhSach.DataSource = dtDanhSachTam;
            dgvDanhSach.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";

            txtSDT.KeyPress += txtSDT_KeyPress;
            txtHoTen.KeyPress += txtHoTen_KeyPress;

            dtpNgaySinh.MaxDate = DateTime.Now;
            dtpNgaySinh.Value = DateTime.Now.AddYears(-16);

            LoadDaDangKy();
            XoaTrang();
            ModeTam();
        }
        //chặn nhập số trong họ tên
        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private bool ValidateInput()
        {
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            DateTime ngaySinh = dtpNgaySinh.Value.Date;

            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Nhập họ tên!");
                txtHoTen.Focus();
                return false;
            }

            if (Regex.IsMatch(hoTen, @"\d"))
            {
                MessageBox.Show("Họ tên không được chứa số!");
                txtHoTen.Focus();
                return false;
            }

            if (ngaySinh > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại!");
                dtpNgaySinh.Focus();
                return false;
            }

            if (ngaySinh > DateTime.Now.AddYears(-16).Date)
            {
                MessageBox.Show("Người tham gia phải từ 16 tuổi trở lên!");
                dtpNgaySinh.Focus();
                return false;
            }

            if (!Regex.IsMatch(sdt, @"^0\d{9}$"))
            {
                MessageBox.Show("SĐT không hợp lệ!");
                txtSDT.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập email!");
                txtEmail.Focus();
                return false;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ!");
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            int choConTrong = LayChoConTrong();

            if (choConTrong <= 0)
            {
                MessageBox.Show("Sự kiện này đã hết chỗ, không thể thêm vào danh sách tạm.");
                return;
            }

            if (dtDanhSachTam.Rows.Count >= choConTrong)
            {
                MessageBox.Show(
                    "Số người trong danh sách tạm đã đạt giới hạn số chỗ còn trống!\n" +
                    "Chỗ còn: " + choConTrong
                );
                return;
            }

            string email = txtEmail.Text.Trim();

            if (EmailDaTonTaiTrongDanhSachTam(email))
            {
                MessageBox.Show("Email này đã tồn tại trong danh sách tạm!");
                txtEmail.Focus();
                return;
            }

            if (EmailDaTonTaiTrongSuKien(email))
            {
                MessageBox.Show("Email này đã đăng ký tham dự sự kiện này rồi!");
                txtEmail.Focus();
                return;
            }

            string sdt = txtSDT.Text.Trim();

            if (SdtDaTonTaiTrongDanhSachTam(sdt))
            {
                MessageBox.Show("SĐT này đã tồn tại trong danh sách tạm!");
                txtSDT.Focus();
                return;
            }

            if (SdtDaTonTaiTrongSuKien(sdt))
            {
                MessageBox.Show("SĐT này đã đăng ký tham dự sự kiện này rồi!");
                txtSDT.Focus();
                return;
            }

            dtDanhSachTam.Rows.Add(
                txtHoTen.Text.Trim(),
                dtpNgaySinh.Value.Date,
                cboGioiTinh.Text.Trim(),
                txtSDT.Text.Trim(),
                email
            );

            dgvDanhSach.Refresh();
            XoaTrang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (editingRow < 0) return;
            if (!ValidateInput()) return;

            string email = txtEmail.Text.Trim();

            if (EmailDaTonTaiTrongDanhSachTam(email, editingRow))
            {
                MessageBox.Show("Email này đã tồn tại trong danh sách tạm!");
                txtEmail.Focus();
                return;
            }

            string emailCu = dtDanhSachTam.Rows[editingRow]["Email"].ToString().Trim();

            if (!email.Equals(emailCu, StringComparison.OrdinalIgnoreCase) &&
                EmailDaTonTaiTrongSuKien(email))
            {
                MessageBox.Show("Email này đã đăng ký tham dự sự kiện này rồi!");
                txtEmail.Focus();
                return;
            }

            string sdt = txtSDT.Text.Trim();

            if (SdtDaTonTaiTrongDanhSachTam(sdt, editingRow))
            {
                MessageBox.Show("SĐT này đã tồn tại trong danh sách tạm!");
                txtSDT.Focus();
                return;
            }

            string sdtCu = dtDanhSachTam.Rows[editingRow]["SDT"].ToString().Trim();

            if (sdt != sdtCu && SdtDaTonTaiTrongSuKien(sdt))
            {
                MessageBox.Show("SĐT này đã đăng ký tham dự sự kiện này rồi!");
                txtSDT.Focus();
                return;
            }

            var r = dtDanhSachTam.Rows[editingRow];

            r["HoTen"] = txtHoTen.Text.Trim();
            r["NgaySinh"] = dtpNgaySinh.Value;
            r["GioiTinh"] = cboGioiTinh.Text.Trim();
            r["SDT"] = txtSDT.Text.Trim();
            r["Email"] = email;

            dgvDanhSach.Refresh();
            editingRow = -1;
            XoaTrang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (editingRow < 0 || editingRow >= dtDanhSachTam.Rows.Count)
            {
                MessageBox.Show("Vui lòng chọn một người để xóa!");
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa người này không?",
                                              "Xác nhận xóa",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                dgvDanhSach.ClearSelection();

                dtDanhSachTam.Rows[editingRow].Delete();
                dtDanhSachTam.AcceptChanges();

                editingRow = -1;
                XoaTrang();
                dgvDanhSach.Refresh();

                MessageBox.Show("Xóa thành công!");
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

            if (dtDanhSachTam.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có người tham gia!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // 1. Kiểm tra số chỗ còn trống của sự kiện
                    string sqlChoConTrong = @"
                SELECT 
                    sk.SoLuongToiDa - ISNULL(COUNT(td.MaNTG), 0) AS ChoConTrong
                FROM SuKien sk
                LEFT JOIN ThamDu td ON sk.MaSuKien = td.MaSuKien
                WHERE sk.MaSuKien = @maSK
                GROUP BY sk.SoLuongToiDa";

                    SqlCommand cmdChoConTrong = new SqlCommand(sqlChoConTrong, conn, tran);
                    cmdChoConTrong.Parameters.AddWithValue("@maSK", MaSKDuocChon);

                    object kqCho = cmdChoConTrong.ExecuteScalar();

                    int choConTrong = 0;
                    if (kqCho != null && kqCho != DBNull.Value)
                        choConTrong = Convert.ToInt32(kqCho);

                    // 2. Nếu hết chỗ thì chặn luôn
                    if (choConTrong <= 0)
                    {
                        MessageBox.Show("Sự kiện này đã hết chỗ, không thể đăng ký.");
                        tran.Rollback();
                        return;
                    }

                    // 3. Nếu số người trong danh sách tạm lớn hơn số chỗ còn thì không cho lưu
                    if (dtDanhSachTam.Rows.Count > choConTrong)
                    {
                        MessageBox.Show(
                            "Số người trong danh sách tạm vượt quá số chỗ còn trống!\n" +
                            "Chỗ còn: " + choConTrong + "\n" +
                            "Số người đang đăng ký: " + dtDanhSachTam.Rows.Count
                        );
                        tran.Rollback();
                        return;
                    }

                    // 4. Lấy mã người tham gia lớn nhất hiện tại
                    int currentMax = 0;

                    string sqlMax = @"SELECT MAX(CAST(SUBSTRING(MaNTG,4,LEN(MaNTG)) AS INT)) FROM ThamDu";
                    SqlCommand cmdMax = new SqlCommand(sqlMax, conn, tran);

                    object result = cmdMax.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                        currentMax = Convert.ToInt32(result);

                    // 5. Insert từng người trong danh sách tạm
                    foreach (DataRow r in dtDanhSachTam.Rows)
                    {
                        string email = r["Email"].ToString().Trim();

                        if (EmailDaTonTaiTrongSuKien(email))
                        {
                            MessageBox.Show("Email '" + email + "' đã tồn tại trong danh sách tham dự của sự kiện này!");
                            tran.Rollback();
                            return;
                        }
                    }
                    foreach (DataRow r in dtDanhSachTam.Rows)
                    {
                        currentMax++;
                        string maNTG = "NTG" + currentMax.ToString("D3");

                        string sql = @"INSERT INTO ThamDu
                    (MaNTG, MaSuKien, MaNDK, HoTen, NgaySinh, GioiTinh, SDT, Email, NgayDangKy)
                    VALUES (@ma,@sk,@ndk,@ht,@ns,@gt,@sdt,@email,@ngay)";

                        SqlCommand cmd = new SqlCommand(sql, conn, tran);

                        cmd.Parameters.AddWithValue("@ma", maNTG);
                        cmd.Parameters.AddWithValue("@sk", MaSKDuocChon);
                        cmd.Parameters.AddWithValue("@ndk", MaNDK_Login);
                        cmd.Parameters.AddWithValue("@ht", r["HoTen"]);
                        cmd.Parameters.AddWithValue("@ns", r["NgaySinh"]);
                        cmd.Parameters.AddWithValue("@gt", r["GioiTinh"]);
                        cmd.Parameters.AddWithValue("@sdt", r["SDT"]);
                        cmd.Parameters.AddWithValue("@email",
                            string.IsNullOrWhiteSpace(r["Email"].ToString())
                            ? (object)DBNull.Value
                            : r["Email"]);
                        cmd.Parameters.AddWithValue("@ngay", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }

                    tran.Commit();

                    LoadDaDangKy();
                    dtDanhSachTam.Rows.Clear();
                    dgvDanhSach.Refresh();
                    XoaTrang();
                    ModeTam();

                    MessageBox.Show("Đăng ký thành công!");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dgvDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            ModeTam();
            if (dgvDanhSach.CurrentRow == null) return;
            if (dgvDanhSach.CurrentRow.IsNewRow) return;
            if (dgvDanhSach.CurrentRow.Index < 0) return;
            if (dgvDanhSach.CurrentRow.Index >= dtDanhSachTam.Rows.Count) return;

            editingRow = dgvDanhSach.CurrentRow.Index;

            DataRow r = dtDanhSachTam.Rows[editingRow];

            if (r.RowState == DataRowState.Deleted || r.RowState == DataRowState.Detached)
                return;

            txtHoTen.Text = r["HoTen"].ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(r["NgaySinh"]);
            cboGioiTinh.Text = r["GioiTinh"].ToString();
            txtSDT.Text = r["SDT"].ToString();
            txtEmail.Text = r["Email"].ToString();
        }

        private void XoaTrang()
        {
            txtHoTen.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            dtpNgaySinh.Value = DateTime.Now.AddYears(-16);

            if (cboGioiTinh.Items.Count > 0)
                cboGioiTinh.SelectedIndex = 0;

            editingRow = -1;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuyDangKy_Click(object sender, EventArgs e)
        {
            if (dtDanhSachTam.Rows.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng, không có gì để hủy!");
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc muốn hủy đăng ký tất cả những người này không?",
                                     "Xác nhận hủy đăng ký",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                dtDanhSachTam.Rows.Clear();
                dgvDanhSach.Refresh();
                XoaTrang();
                MessageBox.Show("Đã hủy đăng ký tất cả những người!");
            }
        }
        //đã đăng ký
        void LoadDaDangKy()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
        SELECT MaNTG, HoTen, NgaySinh, GioiTinh, SDT, Email, NgayDangKy
        FROM ThamDu
        WHERE MaSuKien = @maSK AND MaNDK = @maNDK";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@maSK", MaSKDuocChon);
                da.SelectCommand.Parameters.AddWithValue("@maNDK", MaNDK_Login);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDaDangKy.DataSource = dt;
                dgvDaDangKy.ClearSelection();

                btnHuyDangKyDaChon.Enabled = false;
            }
        }
        void ModeTam()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLamMoi.Enabled = true;

            btnDangKy.Enabled = true;
            btnHuyDangKy.Enabled = true;
            btnThoat.Enabled = true;

            btnHuyDangKyDaChon.Enabled = false;
        }

        void ModeDaDangKy()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = false;

            btnDangKy.Enabled = false;
            btnHuyDangKy.Enabled = false;
            btnThoat.Enabled = true;

            btnHuyDangKyDaChon.Enabled = true;
        }
        private void dgvDaDangKy_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDaDangKy.CurrentRow == null) return;
            if (dgvDaDangKy.CurrentRow.IsNewRow) return;

            ModeDaDangKy();
        }

        private void btnHuyDangKyDaChon_Click(object sender, EventArgs e)
        {
            if (dgvDaDangKy.CurrentRow == null || dgvDaDangKy.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn người cần hủy đăng ký!");
                return;
            }

            if (dgvDaDangKy.CurrentRow.Cells["MaNTG"].Value == null)
            {
                MessageBox.Show("Không tìm thấy mã người tham gia!");
                return;
            }

            string maNTG = dgvDaDangKy.CurrentRow.Cells["MaNTG"].Value.ToString();

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn hủy đăng ký người này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rs == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        string sql = "DELETE FROM ThamDu WHERE MaNTG = @ma";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@ma", maNTG);

                        conn.Open();
                        int soDong = cmd.ExecuteNonQuery();

                        if (soDong > 0)
                        {
                            MessageBox.Show("Hủy đăng ký thành công!");
                            LoadDaDangKy();
                            ModeTam();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu để xóa!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        //kiểm tra email có trong sự kiện chưa
        private bool EmailDaTonTaiTrongSuKien(string email)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
            SELECT COUNT(*)
            FROM ThamDu
            WHERE MaSuKien = @maSK AND Email = @email";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maSK", MaSKDuocChon);
                cmd.Parameters.AddWithValue("@email", email.Trim());

                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }

        // kiểm tra trùng email trong ds tạm
        private bool EmailDaTonTaiTrongDanhSachTam(string email, int boQuaDong = -1)
        {
            string emailCanKiem = email.Trim().ToLower();

            for (int i = 0; i < dtDanhSachTam.Rows.Count; i++)
            {
                if (i == boQuaDong) continue;

                string emailRow = dtDanhSachTam.Rows[i]["Email"].ToString().Trim().ToLower();

                if (emailRow == emailCanKiem)
                    return true;
            }

            return false;
        }

        private int LayChoConTrong()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
            SELECT 
                sk.SoLuongToiDa - ISNULL(COUNT(td.MaNTG), 0) AS ChoConTrong
            FROM SuKien sk
            LEFT JOIN ThamDu td ON sk.MaSuKien = td.MaSuKien
            WHERE sk.MaSuKien = @maSK
            GROUP BY sk.SoLuongToiDa";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maSK", MaSKDuocChon);

                conn.Open();
                object kq = cmd.ExecuteScalar();

                if (kq != null && kq != DBNull.Value)
                    return Convert.ToInt32(kq);

                return 0;
            }
        }

        // kiểm tra SĐT đã tồn tại trong sự kiện chưa
        private bool SdtDaTonTaiTrongSuKien(string sdt)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
        SELECT COUNT(*)
        FROM ThamDu
        WHERE MaSuKien = @maSK AND SDT = @sdt";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maSK", MaSKDuocChon);
                cmd.Parameters.AddWithValue("@sdt", sdt.Trim());

                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }

        // kiểm tra SĐT trùng trong danh sách tạm
        private bool SdtDaTonTaiTrongDanhSachTam(string sdt, int boQuaDong = -1)
        {
            string sdtCanKiem = sdt.Trim();

            for (int i = 0; i < dtDanhSachTam.Rows.Count; i++)
            {
                if (i == boQuaDong) continue;

                string sdtRow = dtDanhSachTam.Rows[i]["SDT"].ToString().Trim();

                if (sdtRow == sdtCanKiem)
                    return true;
            }

            return false;
        }


    }
}