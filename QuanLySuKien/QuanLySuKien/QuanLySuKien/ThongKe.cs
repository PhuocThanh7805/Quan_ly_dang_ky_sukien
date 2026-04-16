using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;
namespace QuanLySuKien
{
    public partial class ThongKe : Form
    {
        string strCon = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLySuKien;Integrated Security=True";

        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            // Thiết lập giá trị mặc định cho ComboBox
            cboThoiGian.SelectedIndex = 0; // Chọn "Tất cả"
            ChayTatCaThongKe();
            DinhDangTatCaLuoi();
        }

        // Sự kiện khi người dùng thay đổi bộ lọc thời gian
        private void cboThoiGian_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChayTatCaThongKe();
        }

        private void ChayTatCaThongKe()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    conn.Open();

                    // --- XỬ LÝ BỘ LỌC THỜI GIAN ---
                    string filter = "";
                    string selected = cboThoiGian.Text;

                    switch (selected)
                    {
                        case "Tháng này":
                            filter = " AND MONTH(s.THOIGIANBATDAU) = MONTH(GETDATE()) AND YEAR(s.THOIGIANBATDAU) = YEAR(GETDATE())";
                            break;
                        case "Năm nay":
                            filter = " AND YEAR(s.THOIGIANBATDAU) = YEAR(GETDATE())";
                            break;
                        case "Hôm nay":
                            filter = " AND CAST(s.THOIGIANBATDAU AS DATE) = CAST(GETDATE() AS DATE)";
                            break;
                        default:
                            filter = "";
                            break;
                    }

                    // --- 1. THỐNG KÊ CÁC CON SỐ (DÙNG TEXTBOX/LABEL) ---

                    // Tổng số sự kiện
                    txtTongSK.Text = ExecuteScalarQuery("SELECT COUNT(*) FROM SUKIEN s WHERE 1=1" + filter, conn) ?? "0";

                    // Sự kiện đông người nhất
                    string sqlMax = $@"SELECT TOP 1 s.TENSUKIEN FROM SUKIEN s 
                                      JOIN THAMDU t ON s.MASUKIEN = t.MASUKIEN 
                                      WHERE 1=1 {filter}
                                      GROUP BY s.TENSUKIEN ORDER BY COUNT(t.MANTG) DESC";
                    txtMaxSK.Text = ExecuteScalarQuery(sqlMax, conn) ?? "0";

                    // Sự kiện ít người nhất
                    string sqlMin = $@"SELECT TOP 1 s.TENSUKIEN FROM SUKIEN s 
                                      LEFT JOIN THAMDU t ON s.MASUKIEN = t.MASUKIEN 
                                      WHERE 1=1 {filter}
                                      GROUP BY s.TENSUKIEN ORDER BY COUNT(t.MANTG) ASC";
                    txtMinSK.Text = ExecuteScalarQuery(sqlMin, conn) ?? "0";

                    

                    // --- 2. ĐỔ DỮ LIỆU VÀO CÁC DATAGRIDVIEW ---

                    // Bảng Đang Diễn Ra
                    string sqlDangDienRa = "SELECT TENSUKIEN AS [Đang Diễn Ra] FROM SUKIEN WHERE CAST(THOIGIANBATDAU AS DATE) = CAST(GETDATE() AS DATE)";
                    LoadDataToGrid(sqlDangDienRa, dgvDangDienRa, conn);

                    // Bảng Full Ghế
                    string sqlFullGhe = $@"SELECT s.TENSUKIEN AS [Sự Kiện Full], COUNT(t.MANTG) AS [Số ĐK]
                                          FROM SUKIEN s JOIN THAMDU t ON s.MASUKIEN = t.MASUKIEN
                                          WHERE 1=1 {filter}
                                          GROUP BY s.TENSUKIEN, s.SOLUONGTOIDA
                                          HAVING COUNT(t.MANTG) >= s.SOLUONGTOIDA";
                    DataTable dtFull = LoadDataToGrid(sqlFullGhe, dgvFullGhe, conn);
                    lblFullGheCount.Text = dtFull.Rows.Count.ToString();

                    // Bảng Thống Kê Chung
                    string sqlChung = $@"SELECT s.MASUKIEN AS [Mã SK], s.TENSUKIEN AS [Tên Sự Kiện], 
                                               COUNT(t.MANTG) AS [Số Đăng Ký], s.SOLUONGTOIDA AS [Quy Mô],
                                               CASE WHEN s.SOLUONGTOIDA > 0 THEN (COUNT(t.MANTG) * 100 / s.SOLUONGTOIDA) ELSE 0 END AS [Tỷ Lệ %]
                                        FROM SUKIEN s LEFT JOIN THAMDU t ON s.MASUKIEN = t.MASUKIEN
                                        WHERE 1=1 {filter}
                                        GROUP BY s.MASUKIEN, s.TENSUKIEN, s.SOLUONGTOIDA";
                    DataTable dtChung = LoadDataToGrid(sqlChung, dgvThongKeChung, conn);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê: " + ex.Message);
            }
        }



        private void DinhDangTatCaLuoi()
        {
            FormatGrid(dgvDangDienRa);
            FormatGrid(dgvFullGhe);
            FormatGrid(dgvThongKeChung);

            if (dgvThongKeChung.Columns.Contains("Tỷ Lệ %"))
            {
                dgvThongKeChung.Columns["Tỷ Lệ %"].DefaultCellStyle.Format = "0'%'";
                dgvThongKeChung.Columns["Tỷ Lệ %"].DefaultCellStyle.ForeColor = Color.Red;
                dgvThongKeChung.Columns["Tỷ Lệ %"].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
        }

        private string ExecuteScalarQuery(string query, SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                object result = cmd.ExecuteScalar();
                return (result == null || result == DBNull.Value) ? null : result.ToString();
            }
        }

        private DataTable LoadDataToGrid(string query, DataGridView dgv, SqlConnection conn)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            return dt;
        }

        private void FormatGrid(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void txtMinSK_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvThongKeChung.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
                return;
            }

            try
            {
                // 1. Khởi tạo ứng dụng Excel
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);

                // 2. Định dạng tiêu đề cột
                for (int i = 1; i < dgvThongKeChung.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dgvThongKeChung.Columns[i - 1].HeaderText;
                    // Làm đậm tiêu đề
                    excelApp.Cells[1, i].Font.Bold = true;
                }

                // 3. Xuất dữ liệu từ DataGridView
                for (int i = 0; i < dgvThongKeChung.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvThongKeChung.Columns.Count; j++)
                    {
                        if (dgvThongKeChung.Rows[i].Cells[j].Value != null)
                        {
                            excelApp.Cells[i + 2, j + 1] = dgvThongKeChung.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                // 4. Tự động chỉnh độ rộng cột cho đẹp
                excelApp.Columns.AutoFit();

                // 5. Hiển thị Excel lên
                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}