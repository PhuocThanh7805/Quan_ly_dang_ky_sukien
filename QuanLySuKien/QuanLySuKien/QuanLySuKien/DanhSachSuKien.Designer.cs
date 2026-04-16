namespace QuanLySuKien
{
    partial class DanhSachSuKien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.lblMaSuKien = new System.Windows.Forms.Label();
            this.lblTenSuKien = new System.Windows.Forms.Label();
            this.lblLoaiSuKien = new System.Windows.Forms.Label();
            this.lblNhaToChuc = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblTgBatDau = new System.Windows.Forms.Label();
            this.lblTgKetThuc = new System.Windows.Forms.Label();
            this.lblSlToiDa = new System.Windows.Forms.Label();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.lblChoConTrong = new System.Windows.Forms.Label();
            this.txtMaSuKien = new System.Windows.Forms.TextBox();
            this.txtTenSuKien = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtSlToiDa = new System.Windows.Forms.TextBox();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtChoConTrong = new System.Windows.Forms.TextBox();
            this.cboLoaiSuKien = new System.Windows.Forms.ComboBox();
            this.cboNhaToChuc = new System.Windows.Forms.ComboBox();
            this.dtpTgBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpTgKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnDangKyThamGia = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(420, 37);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(337, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CÁC SỰ KIỆN ĐANG MỞ ĐĂNG KÝ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTimKiem.Location = new System.Drawing.Point(874, 105);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(201, 22);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnTimKiem.Location = new System.Drawing.Point(803, 105);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(67, 22);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnLamMoi.Location = new System.Drawing.Point(182, 131);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(73, 25);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(90, 401);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 62;
            this.dgvDanhSach.RowTemplate.Height = 28;
            this.dgvDanhSach.Size = new System.Drawing.Size(985, 290);
            this.dgvDanhSach.TabIndex = 4;
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            this.dgvDanhSach.SelectionChanged += new System.EventHandler(this.dgvDanhSach_SelectionChanged);
            // 
            // lblMaSuKien
            // 
            this.lblMaSuKien.AutoSize = true;
            this.lblMaSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMaSuKien.Location = new System.Drawing.Point(179, 180);
            this.lblMaSuKien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSuKien.Name = "lblMaSuKien";
            this.lblMaSuKien.Size = new System.Drawing.Size(88, 16);
            this.lblMaSuKien.TabIndex = 5;
            this.lblMaSuKien.Text = "Mã Sự Kiện:";
            // 
            // lblTenSuKien
            // 
            this.lblTenSuKien.AutoSize = true;
            this.lblTenSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTenSuKien.Location = new System.Drawing.Point(179, 220);
            this.lblTenSuKien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSuKien.Name = "lblTenSuKien";
            this.lblTenSuKien.Size = new System.Drawing.Size(94, 16);
            this.lblTenSuKien.TabIndex = 6;
            this.lblTenSuKien.Text = "Tên Sự Kiện:";
            // 
            // lblLoaiSuKien
            // 
            this.lblLoaiSuKien.AutoSize = true;
            this.lblLoaiSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblLoaiSuKien.Location = new System.Drawing.Point(179, 302);
            this.lblLoaiSuKien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoaiSuKien.Name = "lblLoaiSuKien";
            this.lblLoaiSuKien.Size = new System.Drawing.Size(64, 16);
            this.lblLoaiSuKien.TabIndex = 7;
            this.lblLoaiSuKien.Text = "Loại SK:";
            // 
            // lblNhaToChuc
            // 
            this.lblNhaToChuc.AutoSize = true;
            this.lblNhaToChuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNhaToChuc.Location = new System.Drawing.Point(179, 344);
            this.lblNhaToChuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhaToChuc.Name = "lblNhaToChuc";
            this.lblNhaToChuc.Size = new System.Drawing.Size(100, 16);
            this.lblNhaToChuc.TabIndex = 8;
            this.lblNhaToChuc.Text = "Nhà Tổ Chức:";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMoTa.Location = new System.Drawing.Point(179, 262);
            this.lblMoTa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(55, 16);
            this.lblMoTa.TabIndex = 9;
            this.lblMoTa.Text = "Mô Tả:";
            // 
            // lblTgBatDau
            // 
            this.lblTgBatDau.AutoSize = true;
            this.lblTgBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTgBatDau.Location = new System.Drawing.Point(643, 177);
            this.lblTgBatDau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTgBatDau.Name = "lblTgBatDau";
            this.lblTgBatDau.Size = new System.Drawing.Size(65, 16);
            this.lblTgBatDau.TabIndex = 17;
            this.lblTgBatDau.Text = "Bắt Đầu:";
            // 
            // lblTgKetThuc
            // 
            this.lblTgKetThuc.AutoSize = true;
            this.lblTgKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTgKetThuc.Location = new System.Drawing.Point(643, 217);
            this.lblTgKetThuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTgKetThuc.Name = "lblTgKetThuc";
            this.lblTgKetThuc.Size = new System.Drawing.Size(71, 16);
            this.lblTgKetThuc.TabIndex = 18;
            this.lblTgKetThuc.Text = "Kết Thúc:";
            // 
            // lblSlToiDa
            // 
            this.lblSlToiDa.AutoSize = true;
            this.lblSlToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSlToiDa.Location = new System.Drawing.Point(643, 262);
            this.lblSlToiDa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSlToiDa.Name = "lblSlToiDa";
            this.lblSlToiDa.Size = new System.Drawing.Size(79, 16);
            this.lblSlToiDa.TabIndex = 19;
            this.lblSlToiDa.Text = "SL Tối Đa:";
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDiaDiem.Location = new System.Drawing.Point(643, 302);
            this.lblDiaDiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(73, 16);
            this.lblDiaDiem.TabIndex = 20;
            this.lblDiaDiem.Text = "Địa Điểm:";
            // 
            // lblChoConTrong
            // 
            this.lblChoConTrong.AutoSize = true;
            this.lblChoConTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblChoConTrong.Location = new System.Drawing.Point(643, 343);
            this.lblChoConTrong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoConTrong.Name = "lblChoConTrong";
            this.lblChoConTrong.Size = new System.Drawing.Size(114, 16);
            this.lblChoConTrong.TabIndex = 10;
            this.lblChoConTrong.Text = "Chỗ Còn Trống:";
            // 
            // txtMaSuKien
            // 
            this.txtMaSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMaSuKien.Location = new System.Drawing.Point(300, 176);
            this.txtMaSuKien.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSuKien.Name = "txtMaSuKien";
            this.txtMaSuKien.ReadOnly = true;
            this.txtMaSuKien.Size = new System.Drawing.Size(235, 22);
            this.txtMaSuKien.TabIndex = 11;
            // 
            // txtTenSuKien
            // 
            this.txtTenSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTenSuKien.Location = new System.Drawing.Point(300, 216);
            this.txtTenSuKien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSuKien.Name = "txtTenSuKien";
            this.txtTenSuKien.ReadOnly = true;
            this.txtTenSuKien.Size = new System.Drawing.Size(235, 22);
            this.txtTenSuKien.TabIndex = 12;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMoTa.Location = new System.Drawing.Point(300, 258);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ReadOnly = true;
            this.txtMoTa.Size = new System.Drawing.Size(235, 22);
            this.txtMoTa.TabIndex = 15;
            // 
            // txtSlToiDa
            // 
            this.txtSlToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSlToiDa.Location = new System.Drawing.Point(765, 258);
            this.txtSlToiDa.Margin = new System.Windows.Forms.Padding(2);
            this.txtSlToiDa.Name = "txtSlToiDa";
            this.txtSlToiDa.ReadOnly = true;
            this.txtSlToiDa.Size = new System.Drawing.Size(235, 22);
            this.txtSlToiDa.TabIndex = 23;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDiaDiem.Location = new System.Drawing.Point(765, 298);
            this.txtDiaDiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.ReadOnly = true;
            this.txtDiaDiem.Size = new System.Drawing.Size(235, 22);
            this.txtDiaDiem.TabIndex = 24;
            // 
            // txtChoConTrong
            // 
            this.txtChoConTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtChoConTrong.Location = new System.Drawing.Point(765, 339);
            this.txtChoConTrong.Margin = new System.Windows.Forms.Padding(2);
            this.txtChoConTrong.Name = "txtChoConTrong";
            this.txtChoConTrong.ReadOnly = true;
            this.txtChoConTrong.Size = new System.Drawing.Size(235, 22);
            this.txtChoConTrong.TabIndex = 16;
            // 
            // cboLoaiSuKien
            // 
            this.cboLoaiSuKien.Enabled = false;
            this.cboLoaiSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cboLoaiSuKien.Location = new System.Drawing.Point(300, 297);
            this.cboLoaiSuKien.Margin = new System.Windows.Forms.Padding(2);
            this.cboLoaiSuKien.Name = "cboLoaiSuKien";
            this.cboLoaiSuKien.Size = new System.Drawing.Size(235, 24);
            this.cboLoaiSuKien.TabIndex = 13;
            // 
            // cboNhaToChuc
            // 
            this.cboNhaToChuc.Enabled = false;
            this.cboNhaToChuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cboNhaToChuc.Location = new System.Drawing.Point(300, 339);
            this.cboNhaToChuc.Margin = new System.Windows.Forms.Padding(2);
            this.cboNhaToChuc.Name = "cboNhaToChuc";
            this.cboNhaToChuc.Size = new System.Drawing.Size(235, 24);
            this.cboNhaToChuc.TabIndex = 14;
            // 
            // dtpTgBatDau
            // 
            this.dtpTgBatDau.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpTgBatDau.Enabled = false;
            this.dtpTgBatDau.Location = new System.Drawing.Point(765, 173);
            this.dtpTgBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTgBatDau.Name = "dtpTgBatDau";
            this.dtpTgBatDau.Size = new System.Drawing.Size(235, 20);
            this.dtpTgBatDau.TabIndex = 21;
            // 
            // dtpTgKetThuc
            // 
            this.dtpTgKetThuc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpTgKetThuc.Enabled = false;
            this.dtpTgKetThuc.Location = new System.Drawing.Point(765, 213);
            this.dtpTgKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTgKetThuc.Name = "dtpTgKetThuc";
            this.dtpTgKetThuc.Size = new System.Drawing.Size(235, 20);
            this.dtpTgKetThuc.TabIndex = 22;
            // 
            // btnDangKyThamGia
            // 
            this.btnDangKyThamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDangKyThamGia.Location = new System.Drawing.Point(632, 720);
            this.btnDangKyThamGia.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangKyThamGia.Name = "btnDangKyThamGia";
            this.btnDangKyThamGia.Size = new System.Drawing.Size(193, 36);
            this.btnDangKyThamGia.TabIndex = 26;
            this.btnDangKyThamGia.Text = "ĐĂNG KÝ THAM GIA";
            this.btnDangKyThamGia.UseVisualStyleBackColor = true;
            this.btnDangKyThamGia.Click += new System.EventHandler(this.btnDangKyThamGia_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnQuayLai.Location = new System.Drawing.Point(386, 720);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(198, 36);
            this.btnQuayLai.TabIndex = 25;
            this.btnQuayLai.Text = "QUAY LẠI TRANG CHỦ";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // DanhSachSuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1156, 789);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.lblMaSuKien);
            this.Controls.Add(this.lblTenSuKien);
            this.Controls.Add(this.lblLoaiSuKien);
            this.Controls.Add(this.lblNhaToChuc);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblChoConTrong);
            this.Controls.Add(this.txtMaSuKien);
            this.Controls.Add(this.txtTenSuKien);
            this.Controls.Add(this.cboLoaiSuKien);
            this.Controls.Add(this.cboNhaToChuc);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtChoConTrong);
            this.Controls.Add(this.lblTgBatDau);
            this.Controls.Add(this.lblTgKetThuc);
            this.Controls.Add(this.lblSlToiDa);
            this.Controls.Add(this.lblDiaDiem);
            this.Controls.Add(this.dtpTgBatDau);
            this.Controls.Add(this.dtpTgKetThuc);
            this.Controls.Add(this.txtSlToiDa);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnDangKyThamGia);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DanhSachSuKien";
            this.Text = "DanhSachSuKien";
            this.Load += new System.EventHandler(this.DanhSachSuKien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle, lblMaSuKien, lblTenSuKien, lblLoaiSuKien, lblNhaToChuc, lblMoTa, lblTgBatDau, lblTgKetThuc, lblSlToiDa, lblDiaDiem, lblChoConTrong;
        private System.Windows.Forms.TextBox txtTimKiem, txtMaSuKien, txtTenSuKien, txtMoTa, txtSlToiDa, txtDiaDiem, txtChoConTrong;
        private System.Windows.Forms.Button btnTimKiem, btnLamMoi, btnDangKyThamGia, btnQuayLai;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.ComboBox cboLoaiSuKien, cboNhaToChuc;
        private System.Windows.Forms.DateTimePicker dtpTgBatDau, dtpTgKetThuc;
    }
}