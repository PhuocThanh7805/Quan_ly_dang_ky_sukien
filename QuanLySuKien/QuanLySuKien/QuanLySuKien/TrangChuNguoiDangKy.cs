using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySuKien
{
    public partial class TrangChuNguoiDangKy : Form
    {
        public string Username;
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLySuKien;Integrated Security=True";

        public TrangChuNguoiDangKy()
        {
            InitializeComponent();
        }

        private void btnDanhSachSuKien_Click(object sender, EventArgs e)
        {
            DanhSachSuKien f = new DanhSachSuKien();
            f.Username = this.Username;
            f.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
                "Bạn có muốn đăng xuất không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCapNhatThongTin_Click(object sender, EventArgs e)
        {
            FormDangKi f = new FormDangKi();
            f.Username = this.Username;
            f.IsUpdate = true;
            f.ShowDialog();

            LoadTenNguoiDung();
        }

        private void TrangChuNguoiDangKy_Load(object sender, EventArgs e)
        {
            LoadTenNguoiDung();
        }

        private void LoadTenNguoiDung()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT TenNDK FROM NguoiDangKy WHERE username = @user";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", Username);

                conn.Open();
                object kq = cmd.ExecuteScalar();

                if (kq != null)
                {
                    lblXinChao.Text = "Xin chào, " + kq.ToString();
                }
                else
                {
                    lblXinChao.Text = "Xin chào";
                }
            }
        }
    }
}