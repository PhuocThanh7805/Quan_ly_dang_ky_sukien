using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySuKien
{
    public partial class QuanLyLoaiSuKien : Form
    {
        SqlConnection conn;

        public QuanLyLoaiSuKien()
        {
            InitializeComponent();
        }

        void KetNoi()
        {
            string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLySuKien;Integrated Security=True";
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        void LoadData()
        {
            string sql = "SELECT * FROM LOAISUKIEN";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvLoaiSuKien.DataSource = dt;
        }

        void ChonDongCuoi()
        {
            if (dgvLoaiSuKien.Rows.Count > 0)
            {
                int last = dgvLoaiSuKien.Rows.Count - 1;
                dgvLoaiSuKien.ClearSelection();
                dgvLoaiSuKien.Rows[last].Selected = true;
            }
        }

        

        string TaoMaTuDong()
        {
            string sql = "SELECT TOP 1 MALOAI FROM LOAISUKIEN ORDER BY MALOAI DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            object result = cmd.ExecuteScalar();

            if (result == null || result == DBNull.Value)
                return "LS001";

            string ma = result.ToString();
            int so = int.Parse(ma.Substring(2));
            so++;

            return "LS" + so.ToString("D3");
        }

        void ResetForm()
        {
            txtMaLoai.Text = TaoMaTuDong();
            txtTenLoai.Clear();
            txtTimKiem.Clear();
        }

        private void QuanLyLoaiSuKien_Load(object sender, EventArgs e)
        {
            try
            {
                KetNoi();
                LoadData();
                
                ChonDongCuoi();

                txtMaLoai.Enabled = false;
                txtMaLoai.Text = TaoMaTuDong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối dữ liệu: " + ex.Message);
            }
        }

        private void dgvLoaiSuKien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0 && dgvLoaiSuKien.Rows[i].Cells[0].Value != null)
            {
                txtMaLoai.Text = dgvLoaiSuKien.Rows[i].Cells[0].Value.ToString();
                txtTenLoai.Text = dgvLoaiSuKien.Rows[i].Cells[1].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!");
                return;
            }

            try
            {
                string maMoi = TaoMaTuDong();
                txtMaLoai.Text = maMoi;

                string sql = "INSERT INTO LOAISUKIEN VALUES (@ma, @ten)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", txtMaLoai.Text);
                cmd.Parameters.AddWithValue("@ten", txtTenLoai.Text.Trim());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm thành công!");

                LoadData();
                
                ChonDongCuoi();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLoai.Text) || string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!");
                return;
            }

            string sql = "UPDATE LOAISUKIEN SET TENLOAI = @ten WHERE MALOAI = @ma";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", txtMaLoai.Text);
                cmd.Parameters.AddWithValue("@ten", txtTenLoai.Text.Trim());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Sửa thành công!");

                LoadData();
                
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLoai.Text))
            {
                MessageBox.Show("Vui lòng chọn loại sự kiện cần xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (kq == DialogResult.Yes)
            {
                string sql = "DELETE FROM LOAISUKIEN WHERE MALOAI = @ma";

                try
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtMaLoai.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa thành công!");

                    LoadData();
                    
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string tk = txtTimKiem.Text.Trim();

                    string sql = @"
                        SELECT * FROM LOAISUKIEN
                        WHERE MALOAI LIKE @tk OR TENLOAI LIKE @tk";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@tk", "%" + tk + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvLoaiSuKien.DataSource = dt;

                    e.SuppressKeyPress = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
                }
            }
        }

        private void QuanLyLoaiSuKien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}