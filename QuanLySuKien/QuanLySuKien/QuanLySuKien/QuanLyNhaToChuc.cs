using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySuKien
{
    public partial class QuanLyNhaToChuc : Form
    {
        SqlConnection conn = new SqlConnection(
        @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLySuKien;Integrated Security=True");

        DataTable dt = new DataTable();
        public QuanLyNhaToChuc()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHATOCHUC", conn);
            dt.Clear();
            da.Fill(dt);
            dgvNTC.DataSource = dt;
        }

        private void QuanLyNhaToChuc_Load(object sender, EventArgs e)
        {
            LoadData();
            txtMaNTC.ReadOnly = true;
            txtMaNTC.Text = TaoMaNTCTuDong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNTC.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhà tổ chức!");
                txtTenNTC.Focus();
                return;
            }

            if (txtLienHe.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin liên hệ!");
                txtLienHe.Focus();
                return;
            }

            txtMaNTC.Text = TaoMaNTCTuDong();

            string sql = "INSERT INTO NhaToChuc (MaNhaToChuc, TenNhaToChuc, THONGTINLIENHE) " +
                         "VALUES (@ma, @ten, @lienhe)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma", txtMaNTC.Text);
            cmd.Parameters.AddWithValue("@ten", txtTenNTC.Text.Trim());
            cmd.Parameters.AddWithValue("@lienhe", txtLienHe.Text.Trim());

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadData();
                MessageBox.Show("Thêm thành công!");

                txtMaNTC.Text = TaoMaNTCTuDong();
                txtTenNTC.Clear();
                txtLienHe.Clear();
                txtTenNTC.Focus();
            }
            catch (SqlException ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNTC.Text == "")
            {
                MessageBox.Show("Chọn dữ liệu cần sửa!");
                return;
            }

            if (txtTenNTC.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhà tổ chức!");
                txtTenNTC.Focus();
                return;
            }

            if (txtLienHe.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin liên hệ!");
                txtLienHe.Focus();
                return;
            }

            string sql = "UPDATE NhaToChuc SET TenNhaToChuc=@ten, THONGTINLIENHE=@lienhe WHERE MaNhaToChuc=@ma";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma", txtMaNTC.Text);
            cmd.Parameters.AddWithValue("@ten", txtTenNTC.Text);
            cmd.Parameters.AddWithValue("@lienhe", txtLienHe.Text);

            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                if (rows == 0)
                {
                    MessageBox.Show("Không tìm thấy mã để sửa!");
                    return;
                }

                LoadData();
                MessageBox.Show("Sửa thành công!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi sửa dữ liệu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNTC.Text == "")
            {
                MessageBox.Show("Chọn dữ liệu cần xóa!");
                return;
            }

            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa?", "Xóa", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                string sql = "DELETE FROM NHATOCHUC WHERE MANHATOCHUC=@ma";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", txtMaNTC.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                LoadData();
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNTC.Text = TaoMaNTCTuDong();
            txtTenNTC.Clear();
            txtLienHe.Clear();
            txtTenNTC.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNTC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtMaNTC.Text = dgvNTC.Rows[e.RowIndex].Cells["MaNhaToChuc"].Value.ToString();
            txtTenNTC.Text = dgvNTC.Rows[e.RowIndex].Cells["TenNhaToChuc"].Value.ToString();
            txtLienHe.Text = dgvNTC.Rows[e.RowIndex].Cells["THONGTINLIENHE"].Value.ToString();
        }



        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = $"TenNhaToChuc LIKE '%{txtTimKiem.Text}%'";
            dgvNTC.DataSource = dv;
        }

        string TaoMaNTCTuDong()
        {
            string sql = "SELECT TOP 1 MANHATOCHUC FROM NHATOCHUC ORDER BY MANHATOCHUC DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                object result = cmd.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                    return "NTC001";

                string maCuoi = result.ToString();   // ví dụ: NTC002
                int so = int.Parse(maCuoi.Substring(3)); // lấy phần số sau NTC
                so++;

                return "NTC" + so.ToString("D3");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKeNhaToChuc f = new ThongKeNhaToChuc();
            f.ShowDialog();
        }
    }
}
