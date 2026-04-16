using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLySuKien
{
    public partial class ThongKeNhaToChuc : Form
    {
        SqlConnection conn = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLySuKien;Integrated Security=True");

        public ThongKeNhaToChuc()
        {
            InitializeComponent();
        }

        private void ThongKeNhaToChuc_Load(object sender, EventArgs e)
        {
            LoadComboBoxThoiGian();
            LoadThongKe();
        }

        void LoadComboBoxThoiGian()
        {
            cboThoiGian.Items.Clear();
            cboThoiGian.Items.Add("Tất cả");
            cboThoiGian.Items.Add("Tháng này");
            cboThoiGian.Items.Add("Năm nay");
            cboThoiGian.SelectedIndex = 0;
        }

        void LoadThongKe()
        {
            string dieuKien = "";

            if (cboThoiGian.SelectedItem != null)
            {
                string luaChon = cboThoiGian.SelectedItem.ToString();

                if (luaChon == "Tháng này")
                {
                    dieuKien = @"
                        AND MONTH(SK.ThoiGianBatDau) = MONTH(GETDATE())
                        AND YEAR(SK.ThoiGianBatDau) = YEAR(GETDATE())";
                }
                else if (luaChon == "Năm nay")
                {
                    dieuKien = @"
                        AND YEAR(SK.ThoiGianBatDau) = YEAR(GETDATE())";
                }
            }

            string sql = $@"
                SELECT 
                    NTC.MaNhaToChuc AS [Mã Nhà Tổ Chức],
                    NTC.TenNhaToChuc AS [Tên Nhà Tổ Chức],
                    COUNT(SK.MaSuKien) AS [Số Sự Kiện]
                FROM NhaToChuc NTC
                LEFT JOIN SuKien SK 
                    ON NTC.MaNhaToChuc = SK.MaNhaToChuc {dieuKien}
                GROUP BY NTC.MaNhaToChuc, NTC.TenNhaToChuc";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvThongKe.DataSource = dt;
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cboThoiGian_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThongKe();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvThongKe.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return;
            }

            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Excel.Worksheet sheet = workbook.ActiveSheet;
            sheet.Name = "ThongKeNhaToChuc";

            var cols = dgvThongKe.Columns
                .Cast<DataGridViewColumn>()
                .Where(c => c.Visible)
                .OrderBy(c => c.DisplayIndex)
                .ToList();

            for (int i = 0; i < cols.Count; i++)
            {
                sheet.Cells[1, i + 1] = cols[i].HeaderText;
            }

            for (int r = 0; r < dgvThongKe.Rows.Count; r++)
            {
                if (dgvThongKe.Rows[r].IsNewRow) continue;

                for (int c = 0; c < cols.Count; c++)
                {
                    var value = dgvThongKe.Rows[r].Cells[cols[c].Name].Value;
                    sheet.Cells[r + 2, c + 1] = value?.ToString();
                }
            }

            sheet.Columns.AutoFit();

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel File|*.xlsx";
            save.FileName = "ThongKeNhaToChuc.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(save.FileName);
                workbook.Close();
                excel.Quit();

                MessageBox.Show("Xuất Excel thành công!");
            }
            else
            {
                workbook.Close(false);
                excel.Quit();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}