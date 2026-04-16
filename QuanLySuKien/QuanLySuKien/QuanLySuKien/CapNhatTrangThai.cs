using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySuKien
{
    public partial class CapNhatTrangThai : Form
    {
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLySuKien;Integrated Security=True";
        DataTable dtSuKien = new DataTable();
        string maSuKien;

        public CapNhatTrangThai(string maSK, string tenSK)
        {
            InitializeComponent();
            maSuKien = maSK;
            txtTenSK.Text = tenSK;
        }

        void LoadTrangThai()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT MaTrangThaiSK, MoTaTTSK FROM TrangThaiSuKien";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ccbTrangThaiSK.DataSource = dt;
                ccbTrangThaiSK.DisplayMember = "MoTaTTSK";
                ccbTrangThaiSK.ValueMember = "MaTrangThaiSK";
                ccbTrangThaiSK.SelectedIndex = -1;
            }
        }

        void LoadLichSu()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
                    SELECT td.MaSuKien, ttsk.MoTaTTSK, td.ThoiDiemCapNhat
                    FROM ThoiDiemCapNhat td
                    JOIN TrangThaiSuKien ttsk
                        ON td.MaTrangThaiSK = ttsk.MaTrangThaiSK
                    WHERE td.MaSuKien = @MaSuKien
                    ORDER BY td.ThoiDiemCapNhat DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaSuKien", maSuKien);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLichSu.DataSource = dt;
            }
        }

        private void CapNhatTrangThai_Load(object sender, EventArgs e)
        {
            LoadTrangThai();
            LoadLichSu();
            dgvLichSu.Columns["ThoiDiemCapNhat"].Width = 200;
        }

        private string LayTrangThaiHienTai()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
            SELECT TOP 1 MaTrangThaiSK
            FROM ThoiDiemCapNhat
            WHERE MaSuKien = @MaSuKien
            ORDER BY ThoiDiemCapNhat DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSuKien", maSuKien);

                conn.Open();
                object kq = cmd.ExecuteScalar();

                if (kq != null)
                    return kq.ToString();

                return "";
            }
        }

        private int ThuTuTrangThai(string maTrangThai)
        {
            switch (maTrangThai)
            {
                case "TT001": return 1;
                case "TT002": return 2;
                case "TT003": return 3;
                default: return 0;
            }
        }


        private void btn_LuuTrangThai_Click(object sender, EventArgs e)
        {
            if (ccbTrangThaiSK.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trạng thái sự kiện.");
                ccbTrangThaiSK.Focus();
                return;
            }

            string maTrangThaiMoi = ccbTrangThaiSK.SelectedValue.ToString();
            string maTrangThaiCu = LayTrangThaiHienTai();

            if (maTrangThaiMoi == maTrangThaiCu)
            {
                DialogResult trung = MessageBox.Show(
                    "Sự kiện đang ở trạng thái này rồi. Bạn vẫn muốn lưu thêm một lần cập nhật?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (trung == DialogResult.No)
                    return;
            }
            else if (ThuTuTrangThai(maTrangThaiMoi) < ThuTuTrangThai(maTrangThaiCu))
            {
                DialogResult lui = MessageBox.Show(
                    "Bạn đang cập nhật về trạng thái trước đó. Có thể đây là thao tác sửa lại. Bạn có chắc muốn tiếp tục không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (lui == DialogResult.No)
                    return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
            INSERT INTO ThoiDiemCapNhat(MaSuKien, MaTrangThaiSK, ThoiDiemCapNhat)
            VALUES (@MaSuKien, @MaTrangThai, @ThoiDiemCapNhat)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSuKien", maSuKien);
                cmd.Parameters.AddWithValue("@MaTrangThai", maTrangThaiMoi);
                cmd.Parameters.AddWithValue("@ThoiDiemCapNhat", DateTime.Now);

                conn.Open();
                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật trạng thái thành công.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật trạng thái thất bại.");
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
