using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySuKien
{
    public partial class FormDangNhap : Form
    {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLySuKien;Integrated Security=True";
        SqlConnection conn;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // ADMIN
            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Đăng nhập Admin thành công!");

                this.Hide();

                TrangChuAdmin f = new TrangChuAdmin();
                f.ShowDialog();

                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
                this.Show();

                return;
            }

            // USER trong DB
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"SELECT COUNT(*) 
                       FROM NguoiDangKy
                       WHERE username = @username AND password = @password";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!");

                    this.Hide();

                    TrangChuNguoiDangKy f = new TrangChuNguoiDangKy();
                    f.Username = username;
                    f.ShowDialog();

                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                    this.Show();

                    return;
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKi f = new FormDangKi();
            f.ShowDialog();

            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
