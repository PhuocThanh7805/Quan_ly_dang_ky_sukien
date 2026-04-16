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
    public partial class TrangChuAdmin : Form
    {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLySuKien;Integrated Security=True";
        SqlConnection conn;
        public TrangChuAdmin()
        {
            InitializeComponent();
        }

        private void btnQuanLySuKien_Click(object sender, EventArgs e)
        {
            QuanLySuKien f = new QuanLySuKien();
            f.ShowDialog();
        }

        private void btnQuanLyLoaiSuKien_Click(object sender, EventArgs e)
        {
            QuanLyLoaiSuKien f = new QuanLyLoaiSuKien();
            f.ShowDialog();
        }

        private void btnQuanLyNhaToChuc_Click(object sender, EventArgs e)
        {
            QuanLyNhaToChuc f = new QuanLyNhaToChuc();
            f.ShowDialog();
        }


        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất không?",
                                     "Xác nhận",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                this.Close(); 
            }
        }

        private void TrangChuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe f = new ThongKe();
            f.ShowDialog();
        }

        private void TrangChuAdmin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
