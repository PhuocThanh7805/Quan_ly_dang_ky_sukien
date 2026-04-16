using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLySuKien
{
    public partial class QuanLySuKien : Form
    {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLySuKien;Integrated Security=True";
        DataTable dtSuKien = new DataTable();

        bool isAdding = false;
        bool isEditing = false;

        public QuanLySuKien()
        {
            InitializeComponent();
        }

        private void QuanLySuKien_Load(object sender, EventArgs e)
        {
            dgvSuKien.AllowUserToAddRows = false;
            txtMaSuKien.ReadOnly = true;

            dtpBatDau.Format = DateTimePickerFormat.Custom;
            dtpBatDau.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpBatDau.ShowUpDown = true;

            dtpKetThuc.Format = DateTimePickerFormat.Custom;
            dtpKetThuc.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpKetThuc.ShowUpDown = true;

            LoadLoaiSuKien();
            LoadNhaToChuc();
            LoadLocTrangThai();
            LoadSuKien();
            

            ClearForm();
            KhoaForm();

            isAdding = false;
            isEditing = false;
            CapNhatTrangThaiNut();
        }

 

        void KhoaForm()
        {
            txtTenSuKien.ReadOnly = true;
            txtMoTa.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtDiaDiem.ReadOnly = true;

            cboLoai.Enabled = false;
            cboNhaToChuc.Enabled = false;

            dtpBatDau.Enabled = false;
            dtpKetThuc.Enabled = false;
        }

        void MoForm()
        {
            txtTenSuKien.ReadOnly = false;
            txtMoTa.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtDiaDiem.ReadOnly = false;

            cboLoai.Enabled = true;
            cboNhaToChuc.Enabled = true;

            dtpBatDau.Enabled = true;
            dtpKetThuc.Enabled = true;
        }

        private void CapNhatTrangThaiNut()
        {
            btnCapNhatTrangThai.Enabled = !isAdding;
            btnDanhSachNguoiThamDu.Enabled = !isAdding;
            btnXoa.Enabled = !isAdding;
        }

        private void LoadLoaiSuKien()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT MaLoai, TenLoai FROM LoaiSuKien";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboLoai.DataSource = dt;
                cboLoai.DisplayMember = "TenLoai";
                cboLoai.ValueMember = "MaLoai";
                cboLoai.SelectedIndex = -1;
            }
        }

        private void LoadNhaToChuc()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT MaNhaToChuc, TenNhaToChuc FROM NhaToChuc";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboNhaToChuc.DataSource = dt;
                cboNhaToChuc.DisplayMember = "TenNhaToChuc";
                cboNhaToChuc.ValueMember = "MaNhaToChuc";
                cboNhaToChuc.SelectedIndex = -1;
            }
        }

        private void LoadSuKien()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
                SELECT 
                    sk.MaSuKien,
                    sk.MaLoai,
                    sk.MaNhaToChuc,
                    sk.TenSuKien,
                    lsk.TenLoai,
                    ntc.TenNhaToChuc,
                    sk.MoTaSuKien,
                    sk.ThoiGianBatDau,
                    sk.ThoiGianKetThuc,
                    sk.SoLuongToiDa,

                    (sk.SoLuongToiDa - ISNULL(tdsl.SoNguoiDangKy,0)) AS ChoConTrong,

                    sk.DiaDiem,
                    ttsk.MoTaTTSK AS TrangThaiHienTai

                FROM SuKien sk

                LEFT JOIN LoaiSuKien lsk ON sk.MaLoai = lsk.MaLoai
                LEFT JOIN NhaToChuc ntc ON sk.MaNhaToChuc = ntc.MaNhaToChuc

                LEFT JOIN
                (
                    SELECT MaSuKien, COUNT(*) AS SoNguoiDangKy
                    FROM ThamDu
                    GROUP BY MaSuKien
                ) tdsl ON sk.MaSuKien = tdsl.MaSuKien

                LEFT JOIN (
                    SELECT t1.MaSuKien, t1.MaTrangThaiSK, t1.ThoiDiemCapNhat
                    FROM ThoiDiemCapNhat t1
                    WHERE t1.ThoiDiemCapNhat =
                    (
                        SELECT MAX(t2.ThoiDiemCapNhat)
                        FROM ThoiDiemCapNhat t2
                        WHERE t2.MaSuKien = t1.MaSuKien
                    )
                ) td ON sk.MaSuKien = td.MaSuKien

                LEFT JOIN TrangThaiSuKien ttsk
                    ON td.MaTrangThaiSK = ttsk.MaTrangThaiSK

                ORDER BY
                CASE
                    WHEN ttsk.MoTaTTSK = N'Đang diễn ra' THEN 1
                    WHEN ttsk.MoTaTTSK = N'Sắp diễn ra' THEN 2
                    WHEN ttsk.MoTaTTSK = N'Đã kết thúc' THEN 3
                END,
                sk.ThoiGianBatDau ASC
                ";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                dtSuKien.Clear();
                da.Fill(dtSuKien);
                dgvSuKien.DataSource = dtSuKien;

                //báo het cho
                foreach (DataGridViewRow r in dgvSuKien.Rows)
                {
                    if (r.Cells["ChoConTrong"].Value != null)
                    {
                        int cho = Convert.ToInt32(r.Cells["ChoConTrong"].Value);

                        if (cho <= 0)
                            r.Cells["ChoConTrong"].Style.ForeColor = Color.Red;
                    }
                }

                dgvSuKien.Columns["MaLoai"].Visible = false;
                dgvSuKien.Columns["MaNhaToChuc"].Visible = false;

                dgvSuKien.Columns["MaSuKien"].HeaderText = "Mã sự kiện";
                dgvSuKien.Columns["TenSuKien"].HeaderText = "Tên sự kiện";
                dgvSuKien.Columns["TenLoai"].HeaderText = "Tên loại";
                dgvSuKien.Columns["TenNhaToChuc"].HeaderText = "Nhà tổ chức";
                dgvSuKien.Columns["MoTaSuKien"].HeaderText = "Mô tả";
                dgvSuKien.Columns["ThoiGianBatDau"].HeaderText = "Bắt đầu";
                dgvSuKien.Columns["ThoiGianKetThuc"].HeaderText = "Kết thúc";
                dgvSuKien.Columns["SoLuongToiDa"].HeaderText = "Số lượng";
                dgvSuKien.Columns["ChoConTrong"].HeaderText = "Chỗ còn";
                dgvSuKien.Columns["ChoConTrong"].DisplayIndex = 9;
                dgvSuKien.Columns["DiaDiem"].HeaderText = "Địa điểm";
                dgvSuKien.Columns["TrangThaiHienTai"].HeaderText = "Trạng thái";
            }
        }

        private void ClearForm()
        {
            txtMaSuKien.Text = "";
            txtTenSuKien.Clear();
            txtMoTa.Clear();
            txtSoLuong.Clear();
            txtDiaDiem.Clear();

            cboLoai.SelectedIndex = -1;
            cboNhaToChuc.SelectedIndex = -1;

            dtpBatDau.Value = DateTime.Now;
            dtpKetThuc.Value = DateTime.Now;
        }

        private string TaoMaSuKien()
        {
            string ma = "SK001";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string sql = @"SELECT MAX(CAST(SUBSTRING(MaSuKien, 3, LEN(MaSuKien) - 2) AS INT))
                               FROM SuKien";

                SqlCommand cmd = new SqlCommand(sql, conn);
                object kq = cmd.ExecuteScalar();

                if (kq != DBNull.Value && kq != null)
                {
                    int so = Convert.ToInt32(kq) + 1;
                    ma = "SK" + so.ToString("D3");
                }
            }

            return ma;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            isEditing = false;

            ClearForm();
            txtMaSuKien.Text = TaoMaSuKien();

            MoForm();
            txtTenSuKien.Focus();

            CapNhatTrangThaiNut();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSuKien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn sự kiện cần sửa.");
                return;
            }

            isEditing = true;
            isAdding = false;

            MoForm();
            txtTenSuKien.Focus();

            CapNhatTrangThaiNut();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maSuKien = txtMaSuKien.Text.Trim();
            string tenSuKien = txtTenSuKien.Text.Trim();
            string moTa = txtMoTa.Text.Trim();
            string soLuongText = txtSoLuong.Text.Trim();
            string diaDiem = txtDiaDiem.Text.Trim();

            if (maSuKien == "")
            {
                MessageBox.Show("Vui lòng bấm Thêm để tạo mã sự kiện.");
                return;
            }

            if (tenSuKien == "")
            {
                MessageBox.Show("Vui lòng nhập tên sự kiện.");
                txtTenSuKien.Focus();
                return;
            }

            if (cboLoai.SelectedIndex == -1 || cboLoai.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại sự kiện.");
                cboLoai.Focus();
                return;
            }

            if (cboNhaToChuc.SelectedIndex == -1 || cboNhaToChuc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhà tổ chức.");
                cboNhaToChuc.Focus();
                return;
            }

            if (soLuongText == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng tối đa.");
                txtSoLuong.Focus();
                return;
            }

            int soLuong;
            if (!int.TryParse(soLuongText, out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng tối đa phải là số nguyên dương.");
                txtSoLuong.Focus();
                return;
            }

            if (diaDiem == "")
            {
                MessageBox.Show("Vui lòng nhập địa điểm.");
                txtDiaDiem.Focus();
                return;
            }

            DateTime batDau = new DateTime(
                dtpBatDau.Value.Year,
                dtpBatDau.Value.Month,
                dtpBatDau.Value.Day,
                dtpBatDau.Value.Hour,
                dtpBatDau.Value.Minute,
                0
            );

            DateTime ketThuc = new DateTime(
                dtpKetThuc.Value.Year,
                dtpKetThuc.Value.Month,
                dtpKetThuc.Value.Day,
                dtpKetThuc.Value.Hour,
                dtpKetThuc.Value.Minute,
                0
            );

            if (ketThuc <= batDau)
            {
                MessageBox.Show("Thời gian kết thúc phải lớn hơn thời gian bắt đầu.");
                return;
            }

            string maLoai = cboLoai.SelectedValue.ToString();
            string maNhaToChuc = cboNhaToChuc.SelectedValue.ToString();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    if (isAdding)
                    {
                        string sqlInsert = @"
                        INSERT INTO SuKien
                        (MaSuKien, MaLoai, MaNhaToChuc, TenSuKien, MoTaSuKien, ThoiGianBatDau, ThoiGianKetThuc, SoLuongToiDa, DiaDiem)
                        VALUES
                        (@MaSuKien, @MaLoai, @MaNhaToChuc, @TenSuKien, @MoTaSuKien, @ThoiGianBatDau, @ThoiGianKetThuc, @SoLuongToiDa, @DiaDiem)";

                        SqlCommand cmdInsert = new SqlCommand(sqlInsert, conn, tran);
                        cmdInsert.Parameters.AddWithValue("@MaSuKien", maSuKien);
                        cmdInsert.Parameters.AddWithValue("@MaLoai", maLoai);
                        cmdInsert.Parameters.AddWithValue("@MaNhaToChuc", maNhaToChuc);
                        cmdInsert.Parameters.AddWithValue("@TenSuKien", tenSuKien);
                        cmdInsert.Parameters.AddWithValue("@MoTaSuKien", moTa);
                        cmdInsert.Parameters.AddWithValue("@ThoiGianBatDau", batDau);
                        cmdInsert.Parameters.AddWithValue("@ThoiGianKetThuc", ketThuc);
                        cmdInsert.Parameters.AddWithValue("@SoLuongToiDa", soLuong);
                        cmdInsert.Parameters.AddWithValue("@DiaDiem", diaDiem);
                        cmdInsert.ExecuteNonQuery();

                        string sqlTrangThaiDau = @"
                        INSERT INTO ThoiDiemCapNhat(MaSuKien, MaTrangThaiSK, ThoiDiemCapNhat)
                        VALUES (@MaSuKien, @MaTrangThaiSK, @ThoiDiemCapNhat)";

                        SqlCommand cmdTrangThai = new SqlCommand(sqlTrangThaiDau, conn, tran);
                        cmdTrangThai.Parameters.AddWithValue("@MaSuKien", maSuKien);
                        cmdTrangThai.Parameters.AddWithValue("@MaTrangThaiSK", "TT001");
                        cmdTrangThai.Parameters.AddWithValue("@ThoiDiemCapNhat", DateTime.Now);
                        cmdTrangThai.ExecuteNonQuery();

                        tran.Commit();
                        MessageBox.Show("Thêm sự kiện thành công.");
                    }
                    else if (isEditing)
                    {
                        string sqlUpdate = @"
                        UPDATE SuKien
                        SET MaLoai = @MaLoai,
                            MaNhaToChuc = @MaNhaToChuc,
                            TenSuKien = @TenSuKien,
                            MoTaSuKien = @MoTaSuKien,
                            ThoiGianBatDau = @ThoiGianBatDau,
                            ThoiGianKetThuc = @ThoiGianKetThuc,
                            SoLuongToiDa = @SoLuongToiDa,
                            DiaDiem = @DiaDiem
                        WHERE MaSuKien = @MaSuKien";

                        SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn, tran);
                        cmdUpdate.Parameters.AddWithValue("@MaSuKien", maSuKien);
                        cmdUpdate.Parameters.AddWithValue("@MaLoai", maLoai);
                        cmdUpdate.Parameters.AddWithValue("@MaNhaToChuc", maNhaToChuc);
                        cmdUpdate.Parameters.AddWithValue("@TenSuKien", tenSuKien);
                        cmdUpdate.Parameters.AddWithValue("@MoTaSuKien", moTa);
                        cmdUpdate.Parameters.AddWithValue("@ThoiGianBatDau", batDau);
                        cmdUpdate.Parameters.AddWithValue("@ThoiGianKetThuc", ketThuc);
                        cmdUpdate.Parameters.AddWithValue("@SoLuongToiDa", soLuong);
                        cmdUpdate.Parameters.AddWithValue("@DiaDiem", diaDiem);

                        int soDong = cmdUpdate.ExecuteNonQuery();

                        if (soDong == 0)
                        {
                            throw new Exception("Không tìm thấy sự kiện để cập nhật.");
                        }

                        tran.Commit();
                        MessageBox.Show("Cập nhật sự kiện thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng bấm Thêm hoặc Sửa trước khi lưu.");
                        tran.Rollback();
                        return;
                    }

                    LoadSuKien();
                    ClearForm();
                    KhoaForm();

                    isAdding = false;
                    isEditing = false;
                    CapNhatTrangThaiNut();
                }
                catch (Exception ex)
                {
                    try
                    {
                        tran.Rollback();
                    }
                    catch { }

                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dgvSuKien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvSuKien.Rows[e.RowIndex];

            if (row.IsNewRow) return;
            if (row.Cells["MaSuKien"].Value == null || row.Cells["MaSuKien"].Value == DBNull.Value) return;

            txtMaSuKien.Text = row.Cells["MaSuKien"].Value?.ToString() ?? "";
            txtTenSuKien.Text = row.Cells["TenSuKien"].Value?.ToString() ?? "";
            txtMoTa.Text = row.Cells["MoTaSuKien"].Value?.ToString() ?? "";
            txtSoLuong.Text = row.Cells["SoLuongToiDa"].Value?.ToString() ?? "";
            txtDiaDiem.Text = row.Cells["DiaDiem"].Value?.ToString() ?? "";

            if (row.Cells["ThoiGianBatDau"].Value != null && row.Cells["ThoiGianBatDau"].Value != DBNull.Value)
                dtpBatDau.Value = Convert.ToDateTime(row.Cells["ThoiGianBatDau"].Value);

            if (row.Cells["ThoiGianKetThuc"].Value != null && row.Cells["ThoiGianKetThuc"].Value != DBNull.Value)
                dtpKetThuc.Value = Convert.ToDateTime(row.Cells["ThoiGianKetThuc"].Value);

            if (row.Cells["MaLoai"].Value != null && row.Cells["MaLoai"].Value != DBNull.Value)
                cboLoai.SelectedValue = row.Cells["MaLoai"].Value.ToString();

            if (row.Cells["MaNhaToChuc"].Value != null && row.Cells["MaNhaToChuc"].Value != DBNull.Value)
                cboNhaToChuc.SelectedValue = row.Cells["MaNhaToChuc"].Value.ToString();

            isAdding = false;
            isEditing = false;

        

            KhoaForm();
            CapNhatTrangThaiNut();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới nên không thể xóa.");
                return;
            }

            string maSuKien = txtMaSuKien.Text.Trim();

            if (maSuKien == "")
            {
                MessageBox.Show("Vui lòng chọn sự kiện cần xóa.");
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa sự kiện này không?",
                                              "Xác nhận",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (rs == DialogResult.No)
                return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string sql1 = "DELETE FROM ThoiDiemCapNhat WHERE MaSuKien = @MaSuKien";
                    SqlCommand cmd1 = new SqlCommand(sql1, conn, tran);
                    cmd1.Parameters.AddWithValue("@MaSuKien", maSuKien);
                    cmd1.ExecuteNonQuery();

                    string sql2 = "DELETE FROM SuKien WHERE MaSuKien = @MaSuKien";
                    SqlCommand cmd2 = new SqlCommand(sql2, conn, tran);
                    cmd2.Parameters.AddWithValue("@MaSuKien", maSuKien);
                    cmd2.ExecuteNonQuery();

                    tran.Commit();

                    MessageBox.Show("Xóa sự kiện thành công.");

                    LoadSuKien();
                    ClearForm();
                    KhoaForm();

                    isAdding = false;
                    isEditing = false;
                    CapNhatTrangThaiNut();
                }
                catch (Exception ex)
                {
                    try
                    {
                        tran.Rollback();
                    }
                    catch { }

                    MessageBox.Show("Lỗi xóa sự kiện: " + ex.Message);
                }
            }
        }

        private void btnCapNhatTrangThai_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới. Hãy lưu sự kiện trước rồi mới cập nhật trạng thái.");
                return;
            }

            if (txtMaSuKien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn sự kiện cần cập nhật trạng thái.");
                return;
            }

            string maSuKien = txtMaSuKien.Text.Trim();
            string tenSuKien = txtTenSuKien.Text.Trim();

            CapNhatTrangThai f = new CapNhatTrangThai(maSuKien, tenSuKien);
            f.ShowDialog();

            LoadSuKien();
        }

        private void btnDanhSachNguoiThamDu_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới. Hãy lưu sự kiện trước rồi mới xem danh sách người tham dự.");
                return;
            }

            if (txtMaSuKien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn sự kiện.");
                return;
            }

            string maSuKien = txtMaSuKien.Text.Trim();
            string tenSuKien = txtTenSuKien.Text.Trim();

            DanhSachNguoiThamDu f = new DanhSachNguoiThamDu(maSuKien, tenSuKien);

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadSuKien();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ApDungBoLoc();
        }

        void LoadLocTrangThai()
        {
            cboLocTrangThai.Items.Clear();
            cboLocTrangThai.Items.Add("Tất cả");
            cboLocTrangThai.Items.Add("Sắp diễn ra");
            cboLocTrangThai.Items.Add("Đang diễn ra");
            cboLocTrangThai.Items.Add("Đã kết thúc");
            cboLocTrangThai.SelectedIndex = 0;
        }
        void ApDungBoLoc()
        {
            try
            {
                if (dtSuKien == null || dtSuKien.Columns.Count == 0)
                    return;

                string tukhoa = txtTimKiem.Text.Trim().Replace("'", "''");
                string trangThai = cboLocTrangThai.Text.Trim().Replace("'", "''");

                string dkTimKiem = "";
                string dkTrangThai = "";

                if (!string.IsNullOrEmpty(tukhoa))
                {
                    dkTimKiem =
                        "Convert(MaSuKien, 'System.String') LIKE '%" + tukhoa + "%' OR " +
                        "Convert(TenSuKien, 'System.String') LIKE '%" + tukhoa + "%' OR " +
                        "Convert(DiaDiem, 'System.String') LIKE '%" + tukhoa + "%' OR " +
                        "Convert(MoTaSuKien, 'System.String') LIKE '%" + tukhoa + "%' OR " +
                        "Convert(TenLoai, 'System.String') LIKE '%" + tukhoa + "%' OR " +
                        "Convert(TenNhaToChuc, 'System.String') LIKE '%" + tukhoa + "%' OR " +
                        "Convert(TrangThaiHienTai, 'System.String') LIKE '%" + tukhoa + "%'";

                    dkTimKiem = "(" + dkTimKiem + ")";
                }

                if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
                {
                    dkTrangThai = "Convert(TrangThaiHienTai, 'System.String') = '" + trangThai + "'";
                }

                string rowFilter = "";

                if (dkTimKiem != "" && dkTrangThai != "")
                    rowFilter = dkTimKiem + " AND " + dkTrangThai;
                else if (dkTimKiem != "")
                    rowFilter = dkTimKiem;
                else if (dkTrangThai != "")
                    rowFilter = dkTrangThai;

                dtSuKien.DefaultView.RowFilter = rowFilter;
                dgvSuKien.DataSource = dtSuKien.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lọc dữ liệu: " + ex.Message);
            }
        }



        private void cboLocTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApDungBoLoc();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSuKien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadSuKien();
            ClearForm();
        }
    }
}