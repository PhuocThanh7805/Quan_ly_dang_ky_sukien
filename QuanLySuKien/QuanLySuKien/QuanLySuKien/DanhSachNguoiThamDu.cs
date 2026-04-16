using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLySuKien
{
    public partial class DanhSachNguoiThamDu : Form
    {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLySuKien;Integrated Security=True";
        SqlConnection conn;
        string maSuKien;
        string tenSuKien;

        public DanhSachNguoiThamDu(string ma, string ten)
        {
            InitializeComponent();
            maSuKien = ma;
            tenSuKien = ten;
        }


        public DanhSachNguoiThamDu()
        {
            InitializeComponent();
        }

        private void DanhSachNguoiThamDu_Load(object sender, EventArgs e)
        {
            txtMaNTG.ReadOnly = true;
            txtNDK.ReadOnly = true;
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            dtpNgayDangKy.Format = DateTimePickerFormat.Custom;
            dtpNgayDangKy.CustomFormat = "dd/MM/yyyy";

            LoadComboBoxSuKien();

            if (!string.IsNullOrEmpty(maSuKien))
            {
                cboSuKien.SelectedValue = maSuKien;
                cboSuKien.Enabled = false;
                LoadDataThamDu("", maSuKien);
            }
            else
            {
                dgvThamDu.DataSource = null;
            }
        }
        private void LoadComboBoxSuKien()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT MaSuKien, TenSuKien FROM SuKien";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboSuKien.DataSource = dt;
                cboSuKien.DisplayMember = "TenSuKien";
                cboSuKien.ValueMember = "MaSuKien";
            }
        }

        private void LoadDataThamDu(string keyword = "", string maSK = "")
        {
            string query = @"SELECT 
        td.MaNTG AS [Mã Người Tham Gia], 
        td.MaSuKien,
        sk.TenSuKien AS [Sự Kiện], 
        td.MaNDK,
        ndk.TenNDK AS [Người Đăng Ký],  
        td.HoTen AS [Họ Tên], 
        td.NgaySinh AS [Ngày Sinh],
        td.GioiTinh AS [Giới Tính],
        td.SDT AS [SĐT],
        td.Email AS [Email],
        td.NgayDangKy AS [Ngày Đăng Ký]
    FROM ThamDu td
    JOIN SuKien sk ON td.MaSuKien = sk.MaSuKien
    JOIN NguoiDangKy ndk ON td.MaNDK = ndk.MaNDK
    WHERE 
        (@maSK = '' OR td.MaSuKien = @maSK)
        AND
        (@kw = '' OR 
            td.HoTen LIKE @kw OR 
            td.SDT LIKE @kw OR 
            sk.TenSuKien LIKE @kw OR
            td.MaNTG LIKE @kw)";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                da.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword.Trim() + "%");
                da.SelectCommand.Parameters.AddWithValue("@maSK", maSK);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvThamDu.DataSource = dt;

                dgvThamDu.Columns["Ngày Sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvThamDu.Columns["Ngày Đăng Ký"].DefaultCellStyle.Format = "dd/MM/yyyy";

                dgvThamDu.Columns["Mã Người Tham Gia"].DisplayIndex = 0;
                dgvThamDu.Columns["Họ Tên"].DisplayIndex = 1;
                dgvThamDu.Columns["Ngày Sinh"].DisplayIndex = 2;
                dgvThamDu.Columns["Giới Tính"].DisplayIndex = 3;
                dgvThamDu.Columns["SĐT"].DisplayIndex = 4;
                dgvThamDu.Columns["Email"].DisplayIndex = 5;
                dgvThamDu.Columns["Người Đăng Ký"].DisplayIndex = 6;
                dgvThamDu.Columns["Sự Kiện"].DisplayIndex = 7;
                dgvThamDu.Columns["Ngày Đăng Ký"].DisplayIndex = 8;

                if (dgvThamDu.Columns.Contains("MaSuKien"))
                    dgvThamDu.Columns["MaSuKien"].Visible = false;

                if (dgvThamDu.Columns.Contains("MaNDK"))
                    dgvThamDu.Columns["MaNDK"].Visible = false;

                FormatDataGridView();
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvThamDu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvThamDu.Rows[e.RowIndex];

                txtMaNTG.Text = row.Cells["Mã Người Tham Gia"].Value?.ToString();
                txtHoTen.Text = row.Cells["Họ Tên"].Value?.ToString();

                if (row.Cells["MaSuKien"].Value != null)
                    cboSuKien.SelectedValue = row.Cells["MaSuKien"].Value.ToString();

                txtGioiTinh.Text = row.Cells["Giới Tính"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtSDT.Text = row.Cells["SĐT"].Value?.ToString();
                txtNDK.Text = row.Cells["Người Đăng Ký"].Value?.ToString();

                if (row.Cells["Ngày Sinh"].Value != DBNull.Value)
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["Ngày Sinh"].Value);

                if (row.Cells["Ngày Đăng Ký"].Value != DBNull.Value)
                    dtpNgayDangKy.Value = Convert.ToDateTime(row.Cells["Ngày Đăng Ký"].Value);
            }
        }
        private void FormatDataGridView()
        {
            if (dgvThamDu.Columns.Count == 0) return;

            dgvThamDu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvThamDu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThamDu.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvThamDu.EnableHeadersVisualStyles = false;
            dgvThamDu.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvThamDu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvThamDu.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvThamDu.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvThamDu.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
        }




        private void txtNDK_TextChanged(object sender, EventArgs e)
        {

        }
        private bool KiemTraNhapLieu()
        {
            // nhap đủ dùm
            if (string.IsNullOrWhiteSpace(txtMaNTG.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtGioiTinh.Text) ||
                string.IsNullOrWhiteSpace(txtNDK.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tất cả các trường thông tin!", "Thông báo");
                return false;
            }

            // sdt 0 end 10
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSDT.Text, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0 và có đúng 10 chữ số!", "Lỗi định dạng");
                txtSDT.Focus();
                return false;
            }

            // email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Định dạng Email không hợp lệ!", "Lỗi định dạng");
                txtEmail.Focus();
                return false;
            }

            //combobox chua chọn keu chon
            if (cboSuKien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một sự kiện!", "Thông báo");
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieu()) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // kiểm tra email trùng (trừ chính dòng đang sửa)
                    string checkSql = @"SELECT COUNT(*) 
                                FROM ThamDu 
                                WHERE Email = @email 
                                AND MaNTG <> @maTG";

                    SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                    checkCmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@maTG", txtMaNTG.Text.Trim());

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Email đã tồn tại, vui lòng nhập email khác!");
                        txtEmail.Focus();
                        return;
                    }

                    // update
                    string sql = @"UPDATE ThamDu 
                           SET MaSuKien=@maSK,
                               HoTen=@hoTen,
                               NgaySinh=@ngaySinh,
                               GioiTinh=@gioiTinh,
                               SDT=@sdt,
                               Email=@email
                           WHERE MaNTG=@maTG";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maTG", txtMaNTG.Text);
                    cmd.Parameters.AddWithValue("@maSK", cboSuKien.SelectedValue);
                    cmd.Parameters.AddWithValue("@hoTen", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@ngaySinh", dtpNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@gioiTinh", txtGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        LoadDataThamDu("", maSuKien);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNTG.Text)) return;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa người này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = "DELETE FROM ThamDu WHERE MaNTG=@ma";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtMaNTG.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadDataThamDu("", maSuKien);
                    btnDatLai_Click(null, null);
                }
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaNTG.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtGioiTinh.Clear();
            txtNDK.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            dtpNgayDangKy.Value = DateTime.Now;
            txtMaNTG.Focus(); // Đưa con trỏ chuột về ô Mã
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn thoát chức năng này?", "Thoát", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }





        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void SendEmail(string toEmail, string subject, string body)
        {
            var fromAddress = new MailAddress("huynhphuocthanh.131019@gmail.com", "Event System");
            string fromPassword = "gmvi hkjy puow rrvx";

            var smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                EnableSsl = true
            };

            MailMessage message = new MailMessage();
            message.From = fromAddress;
            message.To.Add(toEmail);
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = true;

            smtp.Send(message);
        }
        private void GuiMail7NguoiDau()
        {
            int count = 0;
            for (int i = 0; i < dgvThamDu.Rows.Count; i++)
            {
                if (count >= 7) break; // chỉ lấy 7 người
                DataGridViewRow row = dgvThamDu.Rows[i];
                if (row.IsNewRow) continue;
                string email = row.Cells["Email"].Value?.ToString();
                if (string.IsNullOrEmpty(email)) continue;
                string ten = row.Cells["Họ Tên"].Value?.ToString();
                string body = $"Chào {ten}, đây là thông tin sự kiện...";
                SendEmail(email, "Thông báo", body);
                count++;
            }

            MessageBox.Show("Đã gửi 7 mail đầu tiên!");
        }

        private void btnGuiMail_Click(object sender, EventArgs e)
        {
            if (dgvThamDu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn người!");
                return;
            }

            var row = dgvThamDu.CurrentRow;

            string email = row.Cells["Email"].Value?.ToString();
            string ten = row.Cells["Họ Tên"].Value?.ToString();
            string sdt = row.Cells["SĐT"].Value?.ToString();
            string sukien = row.Cells["Sự Kiện"].Value?.ToString();
            string ngayDK = Convert.ToDateTime(row.Cells["Ngày Đăng Ký"].Value).ToString("dd/MM/yyyy");

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Không có email!");
                return;
            }

            string subject = "Xác nhận đăng ký sự kiện";

            string body = $@"
<h2 style='color:blue'>🎉 Xác nhận đăng ký thành công</h2>
<p><b>Họ tên:</b> {ten}</p>
<p><b>SĐT:</b> {sdt}</p>
<p><b>Sự kiện:</b> {sukien}</p>
<p><b>Ngày đăng ký:</b> {ngayDK}</p>
<hr/>
<p>👉 Hẹn gặp bạn tại sự kiện!</p>
";

            SendEmail(email, subject, body);
            GuiMail7NguoiDau();

        }

        private void txtMaNTG_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvThamDu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return;
            }

            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Excel.Worksheet sheet = workbook.ActiveSheet;
            sheet.Name = "DanhSachThamDu";

            // Lấy cột đang hiển thị và sắp theo DisplayIndex
            var cols = dgvThamDu.Columns
                .Cast<DataGridViewColumn>()
                .Where(c => c.Visible)
                .OrderBy(c => c.DisplayIndex)
                .ToList();

            // Header
            for (int i = 0; i < cols.Count; i++)
            {
                sheet.Cells[1, i + 1] = cols[i].HeaderText;
            }

            // Data
            for (int r = 0; r < dgvThamDu.Rows.Count; r++)
            {
                if (dgvThamDu.Rows[r].IsNewRow) continue;

                for (int c = 0; c < cols.Count; c++)
                {
                    var value = dgvThamDu.Rows[r].Cells[cols[c].Name].Value;
                    Excel.Range cell = (Excel.Range)sheet.Cells[r + 2, c + 1];

                    if (value is DateTime dtValue)
                    {
                        cell.Value = dtValue;
                        cell.NumberFormat = "dd/mm/yyyy";
                    }
                    else
                    {
                        cell.Value = value?.ToString();
                    }
                }
            }

            sheet.Columns.AutoFit();

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel File|*.xlsx";
            save.FileName = "DanhSachThamDu.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(save.FileName);
                workbook.Close();
                excel.Quit();

                MessageBox.Show("Xuất Excel thành công!");
            }
        }
    }
}
