namespace QuanLySuKien
{
    partial class DangKyThamDu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnHuyDangKy = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvDaDangKy = new System.Windows.Forms.DataGridView();
            this.lblDaDangKy = new System.Windows.Forms.Label();
            this.btnHuyDangKyDaChon = new System.Windows.Forms.Button();
            this.dst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(488, 35);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐĂNG KÝ THAM DỰ";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(449, 89);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(78, 16);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Sự kiện: ...";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.Location = new System.Drawing.Point(82, 197);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(56, 16);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNamSinh.Location = new System.Drawing.Point(82, 227);
            this.lblNamSinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(80, 16);
            this.lblNamSinh.TabIndex = 3;
            this.lblNamSinh.Text = "Ngày sinh:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblGioiTinh.Location = new System.Drawing.Point(82, 257);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(67, 16);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSDT.Location = new System.Drawing.Point(82, 285);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(41, 16);
            this.lblSDT.TabIndex = 5;
            this.lblSDT.Text = "SĐT:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(82, 314);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 16);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtHoTen.Location = new System.Drawing.Point(170, 193);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(166, 22);
            this.txtHoTen.TabIndex = 7;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSDT.Location = new System.Drawing.Point(170, 281);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(166, 22);
            this.txtSDT.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(170, 310);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboGioiTinh.Location = new System.Drawing.Point(170, 252);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(166, 24);
            this.cboGioiTinh.TabIndex = 9;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(170, 223);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(166, 22);
            this.dtpNgaySinh.TabIndex = 8;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(441, 193);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(587, 189);
            this.dgvDanhSach.TabIndex = 16;
            this.dgvDanhSach.SelectionChanged += new System.EventHandler(this.dgvDanhSach_SelectionChanged);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnThem.Location = new System.Drawing.Point(85, 359);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 23);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSua.Location = new System.Drawing.Point(181, 359);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 23);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnXoa.Location = new System.Drawing.Point(272, 359);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 23);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDangKy.Location = new System.Drawing.Point(536, 395);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(90, 29);
            this.btnDangKy.TabIndex = 17;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnHuyDangKy
            // 
            this.btnHuyDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnHuyDangKy.Location = new System.Drawing.Point(663, 395);
            this.btnHuyDangKy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyDangKy.Name = "btnHuyDangKy";
            this.btnHuyDangKy.Size = new System.Drawing.Size(112, 29);
            this.btnHuyDangKy.TabIndex = 18;
            this.btnHuyDangKy.Text = "Hủy danh sách";
            this.btnHuyDangKy.UseVisualStyleBackColor = true;
            this.btnHuyDangKy.Click += new System.EventHandler(this.btnHuyDangKy_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnLamMoi.Location = new System.Drawing.Point(246, 148);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 23);
            this.btnLamMoi.TabIndex = 15;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnThoat.Location = new System.Drawing.Point(810, 395);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 29);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvDaDangKy
            // 
            this.dgvDaDangKy.AllowUserToAddRows = false;
            this.dgvDaDangKy.AllowUserToDeleteRows = false;
            this.dgvDaDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDaDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaDangKy.Location = new System.Drawing.Point(198, 499);
            this.dgvDaDangKy.MultiSelect = false;
            this.dgvDaDangKy.Name = "dgvDaDangKy";
            this.dgvDaDangKy.ReadOnly = true;
            this.dgvDaDangKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDaDangKy.Size = new System.Drawing.Size(830, 228);
            this.dgvDaDangKy.TabIndex = 20;
            this.dgvDaDangKy.SelectionChanged += new System.EventHandler(this.dgvDaDangKy_SelectionChanged);
            // 
            // lblDaDangKy
            // 
            this.lblDaDangKy.AutoSize = true;
            this.lblDaDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDaDangKy.Location = new System.Drawing.Point(195, 480);
            this.lblDaDangKy.Name = "lblDaDangKy";
            this.lblDaDangKy.Size = new System.Drawing.Size(141, 16);
            this.lblDaDangKy.TabIndex = 21;
            this.lblDaDangKy.Text = "Danh sách đã đăng ký";
            // 
            // btnHuyDangKyDaChon
            // 
            this.btnHuyDangKyDaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnHuyDangKyDaChon.Location = new System.Drawing.Point(528, 750);
            this.btnHuyDangKyDaChon.Name = "btnHuyDangKyDaChon";
            this.btnHuyDangKyDaChon.Size = new System.Drawing.Size(148, 30);
            this.btnHuyDangKyDaChon.TabIndex = 22;
            this.btnHuyDangKyDaChon.Text = "Hủy đăng ký đã chọn";
            this.btnHuyDangKyDaChon.UseVisualStyleBackColor = true;
            this.btnHuyDangKyDaChon.Click += new System.EventHandler(this.btnHuyDangKyDaChon_Click);
            // 
            // dst
            // 
            this.dst.AutoSize = true;
            this.dst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dst.Location = new System.Drawing.Point(438, 175);
            this.dst.Name = "dst";
            this.dst.Size = new System.Drawing.Size(96, 16);
            this.dst.TabIndex = 23;
            this.dst.Text = "Danh sách tạm";
            // 
            // DangKyThamDu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1168, 820);
            this.Controls.Add(this.dst);
            this.Controls.Add(this.btnHuyDangKyDaChon);
            this.Controls.Add(this.lblDaDangKy);
            this.Controls.Add(this.dgvDaDangKy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuyDangKy);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNamSinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DangKyThamDu";
            this.Text = "DangKyThamDu";
            this.Load += new System.EventHandler(this.DangKyThamDu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle, lblSubTitle;
        private System.Windows.Forms.Label lblHoTen, lblNamSinh, lblGioiTinh, lblSDT, lblEmail;
        private System.Windows.Forms.TextBox txtHoTen, txtSDT, txtEmail;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnDangKy, btnHuyDangKy, btnLamMoi, btnThoat;
        private System.Windows.Forms.DataGridView dgvDaDangKy;
        private System.Windows.Forms.Label lblDaDangKy;
        private System.Windows.Forms.Button btnHuyDangKyDaChon;
        private System.Windows.Forms.Label dst;
    }
}