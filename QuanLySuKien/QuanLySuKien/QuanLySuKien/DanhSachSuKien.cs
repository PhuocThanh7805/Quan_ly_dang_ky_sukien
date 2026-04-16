using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace QuanLySuKien
{
    public partial class DanhSachSuKien : Form
    {
        private readonly string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLySuKien;Integrated Security=True";
        public string Username { get; set; } = "Guest";
        private DataTable dtFull = new DataTable();
        private const string PlaceholderText = "Tìm theo tên, địa điểm...";

        public DanhSachSuKien()
        {
            InitializeComponent();
        }

        private void DanhSachSuKien_Load(object sender, EventArgs e)
        {
            LoadDanhSachSuKien();
            dtpTgBatDau.Format = DateTimePickerFormat.Custom;
            dtpTgBatDau.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpTgBatDau.ShowUpDown = true;

            dtpTgKetThuc.Format = DateTimePickerFormat.Custom;
            dtpTgKetThuc.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpTgKetThuc.ShowUpDown = true;
        }

        private void LoadDanhSachSuKien()
        {
            try
            {
                string sql = @"
            SELECT 
                SK.MASUKIEN,
                SK.TENSUKIEN,
                SK.MOTASUKIEN,
                SK.THOIGIANBATDAU,
                SK.THOIGIANKETTHUC,
                SK.SOLUONGTOIDA,
                SK.DIADIEM,
                LSK.TENLOAI,
                NTC.TENNHATOCHUC,

                (SK.SOLUONGTOIDA - 
                    (SELECT COUNT(*) FROM THAMDU WHERE MASUKIEN = SK.MASUKIEN)
                ) AS CHOCONTRONG

            FROM SUKIEN SK
            JOIN LOAISUKIEN LSK ON SK.MALOAI = LSK.MALOAI
            JOIN NHATOCHUC NTC ON SK.MANHATOCHUC = NTC.MANHATOCHUC
            JOIN (
                SELECT t1.MASUKIEN, t1.MATRANGTHAISK
                FROM THOIDIEMCAPNHAT t1
                WHERE t1.THOIDIEMCAPNHAT = (
                    SELECT MAX(t2.THOIDIEMCAPNHAT)
                    FROM THOIDIEMCAPNHAT t2
                    WHERE t2.MASUKIEN = t1.MASUKIEN
                )
            ) TT ON SK.MASUKIEN = TT.MASUKIEN
            WHERE TT.MATRANGTHAISK = 'TT001'";

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    dtFull = new DataTable();
                    da.Fill(dtFull);
                    dgvDanhSach.DataSource = dtFull;

                    dgvDanhSach.Columns["THOIGIANBATDAU"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    dgvDanhSach.Columns["THOIGIANKETTHUC"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                    dgvDanhSach.Columns["CHOCONTRONG"].DisplayIndex = 5;
                    dgvDanhSach.Columns["SOLUONGTOIDA"].DisplayIndex = 6;

                    dgvDanhSach.Columns["CHOCONTRONG"].HeaderText = "Chỗ còn";
                    dgvDanhSach.Columns["SOLUONGTOIDA"].HeaderText = "Số lượng";

                    foreach (DataGridViewRow row in dgvDanhSach.Rows)
                    {
                        if (row.IsNewRow) continue;
                        if (row.Cells["CHOCONTRONG"].Value == null) continue;

                        int choConTrong;
                        if (int.TryParse(row.Cells["CHOCONTRONG"].Value.ToString(), out choConTrong))
                        {
                            if (choConTrong <= 0)
                            {
                                row.Cells["CHOCONTRONG"].Style.ForeColor = Color.Red;
                                row.Cells["CHOCONTRONG"].Style.Font =
                                    new Font(dgvDanhSach.Font, FontStyle.Bold);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void dgvDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null) return;

            var row = dgvDanhSach.CurrentRow;

            txtMaSuKien.Text = row.Cells["MASUKIEN"].Value?.ToString();
            txtTenSuKien.Text = row.Cells["TENSUKIEN"].Value?.ToString();
            txtSlToiDa.Text = row.Cells["SOLUONGTOIDA"].Value?.ToString();
            txtDiaDiem.Text = row.Cells["DIADIEM"].Value?.ToString();
            txtMoTa.Text = row.Cells["MOTASUKIEN"].Value?.ToString();
            txtChoConTrong.Text = row.Cells["CHOCONTRONG"].Value?.ToString();
            cboLoaiSuKien.Text = row.Cells["TENLOAI"].Value?.ToString();
            cboNhaToChuc.Text = row.Cells["TENNHATOCHUC"].Value?.ToString();

            if (row.Cells["THOIGIANBATDAU"].Value != null && row.Cells["THOIGIANBATDAU"].Value != DBNull.Value)
            {
                dtpTgBatDau.Value = Convert.ToDateTime(row.Cells["THOIGIANBATDAU"].Value);
            }

            if (row.Cells["THOIGIANKETTHUC"].Value != null && row.Cells["THOIGIANKETTHUC"].Value != DBNull.Value)
            {
                dtpTgKetThuc.Value = Convert.ToDateTime(row.Cells["THOIGIANKETTHUC"].Value);
            }

            int choConTrong;
            if (!int.TryParse(txtChoConTrong.Text, out choConTrong))
            {
                choConTrong = 0;
            }

            if (choConTrong <= 0)
            {
                btnDangKyThamGia.Enabled = true;
                btnDangKyThamGia.Text = "XEM / HỦY ĐĂNG KÝ";
            }
            else
            {
                btnDangKyThamGia.Enabled = true;
                btnDangKyThamGia.Text = "ĐĂNG KÝ THAM GIA";
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string kw = txtTimKiem.Text.Trim();
            if (kw == PlaceholderText) kw = "";
            DataView dv = dtFull.DefaultView;
            dv.RowFilter = $"TENSUKIEN LIKE '%{kw}%' OR DIADIEM LIKE '%{kw}%'";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachSuKien();
        }

        private void btnDangKyThamGia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSuKien.Text))
            {
                MessageBox.Show("Vui lòng chọn sự kiện.");
                return;
            }

            

            DangKyThamDu frm = new DangKyThamDu();
            frm.MaSKDuocChon = txtMaSuKien.Text;
            frm.TenSKDuocChon = txtTenSuKien.Text;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string sql = "SELECT MaNDK FROM NguoiDangKy WHERE Username = @u";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", Username);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    frm.MaNDK_Login = result.ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy người dùng!");
                    return;
                }
            }

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachSuKien();
            }
        }

        private void txtTimKiem_GotFocus(object sender, EventArgs e) { if (txtTimKiem.Text == PlaceholderText) txtTimKiem.Text = ""; }
        private void txtTimKiem_LostFocus(object sender, EventArgs e) { if (string.IsNullOrWhiteSpace(txtTimKiem.Text)) txtTimKiem.Text = PlaceholderText; }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
