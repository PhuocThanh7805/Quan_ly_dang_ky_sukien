using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySuKien
{
    public partial class FormDangKi : Form
    {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLySuKien;Integrated Security=True";
        public string Username { get; set; } = "";
        public bool IsUpdate { get; set; } = false;

        public FormDangKi()
        {
            InitializeComponent();
        }

        private void FormDangKi_Load(object sender, EventArgs e)
        {
            dtpNamSinh.Format = DateTimePickerFormat.Custom;
            dtpNamSinh.CustomFormat = "dd/MM/yyyy";

            if (IsUpdate && !string.IsNullOrEmpty(Username))
            {
                LoadUserData();
            }
            else
            {
                txtMaNDK.Text = TaoMaNDK();
                txtMaNDK.ReadOnly = true;
            }

            txtPassword.UseSystemPasswordChar = true;
            txtNhapLaiMatKhau.UseSystemPasswordChar = true;
        }

        private void LoadUserData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"SELECT MaNDK, TenNDK, NamSinh, username, password FROM NguoiDangKy WHERE username = @user";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", Username);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtMaNDK.Text = reader["MaNDK"].ToString();
                    txtMaNDK.ReadOnly = true;
                    txtTenNDK.Text = reader["TenNDK"].ToString();
                    DateTime namSinh = (DateTime)reader["NamSinh"];
                    dtpNamSinh.Value = new DateTime(namSinh.Year, 1, 1);
                    txtUsername.Text = reader["username"].ToString();
                    txtUsername.ReadOnly = true;
                    txtPassword.Text = reader["password"].ToString();
                    txtNhapLaiMatKhau.Text = reader["password"].ToString();
                }
            }
        }

        private string TaoMaNDK()
        {
            string ma = "NDK001";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string sql = "SELECT TOP 1 MaNDK FROM NguoiDangKy ORDER BY MaNDK DESC";
                SqlCommand cmd = new SqlCommand(sql, conn);

                object kq = cmd.ExecuteScalar();

                if (kq != null)
                {
                    string maCu = kq.ToString().Trim(); // ví dụ NDK009
                    int so = int.Parse(maCu.Substring(3)) + 1;
                    ma = "NDK" + so.ToString("D3");
                }
            }

            return ma;
        }

        private bool KiemTraUsername(string username)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT COUNT(*) FROM NguoiDangKy WHERE username = @u";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", username);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        private void LamMoiForm()
        {
            txtMaNDK.Text = TaoMaNDK();
            txtTenNDK.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtNhapLaiMatKhau.Clear();
            dtpNamSinh.Value = DateTime.Now;
            txtTenNDK.Focus();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            string ma = txtMaNDK.Text.Trim();
            string ten = txtTenNDK.Text.Trim();
            DateTime ns = dtpNamSinh.Value;
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            string nhapLai = txtNhapLaiMatKhau.Text.Trim();

            if (ten == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên.");
                txtTenNDK.Focus();
                return;
            }

            // Load
            dtpNamSinh.MaxDate = DateTime.Now;

            // Validate
            if (ns > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return;
            }
            if (dtpNamSinh.Value > DateTime.Now.AddYears(-16))
            {
                MessageBox.Show("Bạn phải từ 16 tuổi trở lên!");
                return;
            }

            if (user == "")
            {
                MessageBox.Show("Vui lòng nhập username.");
                txtUsername.Focus();
                return;
            }

            if (pass == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.");
                txtPassword.Focus();
                return;
            }

            if (pass.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.");
                txtPassword.Focus();
                return;
            }

            if (nhapLai == "")
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu.");
                txtNhapLaiMatKhau.Focus();
                return;
            }

            if (pass != nhapLai)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp.");
                txtNhapLaiMatKhau.Focus();
                txtNhapLaiMatKhau.SelectAll();
                return;
            }

            if (pass.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.");
                txtPassword.Focus();
                return;
            }

            // Chỉ kiểm tra username nếu là chế độ đăng ký mới
            if (!IsUpdate && KiemTraUsername(user))
            {
                MessageBox.Show("Username đã tồn tại!");
                txtUsername.Focus();
                txtUsername.SelectAll();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql;
                    SqlCommand cmd;

                    if (IsUpdate)
                    {
                        // Cập nhật thông tin tài khoản
                        sql = @"UPDATE NguoiDangKy SET TenNDK = @ten, NamSinh = @ns, password = @pass WHERE username = @user";
                        cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@ten", ten);
                        cmd.Parameters.AddWithValue("@ns", ns.Date);
                        cmd.Parameters.AddWithValue("@pass", pass);
                        cmd.Parameters.AddWithValue("@user", user);
                    }
                    else
                    {
                        // Đăng ký tài khoản mới
                        sql = @"INSERT INTO NguoiDangKy(MaNDK, TenNDK, NamSinh, username, password)
                               VALUES (@ma, @ten, @ns, @user, @pass)";
                        cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@ma", ma);
                        cmd.Parameters.AddWithValue("@ten", ten);
                        cmd.Parameters.AddWithValue("@ns", ns.Date);
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@pass", pass);
                    }

                    conn.Open();
                    int soDong = cmd.ExecuteNonQuery();

                    if (soDong > 0)
                    {
                        if (IsUpdate)
                        {
                            MessageBox.Show("Cập nhật thông tin thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký thành công!");
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thao tác thất bại, không có dữ liệu nào được cập nhật.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}