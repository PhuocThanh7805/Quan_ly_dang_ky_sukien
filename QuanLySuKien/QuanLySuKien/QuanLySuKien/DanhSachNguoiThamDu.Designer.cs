namespace QuanLySuKien
{
    partial class DanhSachNguoiThamDu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.qldsntdsk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNTG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNDK = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cboSuKien = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dgvThamDu = new System.Windows.Forms.DataGridView();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnGuiMail = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThamDu)).BeginInit();
            this.SuspendLayout();
            // 
            // qldsntdsk
            // 
            this.qldsntdsk.Dock = System.Windows.Forms.DockStyle.Top;
            this.qldsntdsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qldsntdsk.Location = new System.Drawing.Point(0, 0);
            this.qldsntdsk.Name = "qldsntdsk";
            this.qldsntdsk.Size = new System.Drawing.Size(1021, 108);
            this.qldsntdsk.TabIndex = 0;
            this.qldsntdsk.Text = "QUẢN LÝ DANH SÁCH NGƯỜI THAM GIA SỰ KIỆN";
            this.qldsntdsk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(93, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã người tham gia:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMaNTG
            // 
            this.txtMaNTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMaNTG.Location = new System.Drawing.Point(258, 211);
            this.txtMaNTG.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNTG.Name = "txtMaNTG";
            this.txtMaNTG.Size = new System.Drawing.Size(218, 22);
            this.txtMaNTG.TabIndex = 5;
            this.txtMaNTG.TextChanged += new System.EventHandler(this.txtMaNTG_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(380, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sự kiện: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(93, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Người đăng ký";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(93, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên người tham gia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(570, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(570, 215);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Giới tính:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(570, 249);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Số điện thoại:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(570, 283);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(93, 283);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ngày đăng ký:";
            // 
            // txtNDK
            // 
            this.txtNDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNDK.Location = new System.Drawing.Point(258, 174);
            this.txtNDK.Margin = new System.Windows.Forms.Padding(2);
            this.txtNDK.Name = "txtNDK";
            this.txtNDK.Size = new System.Drawing.Size(218, 22);
            this.txtNDK.TabIndex = 14;
            this.txtNDK.TextChanged += new System.EventHandler(this.txtNDK_TextChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtHoTen.Location = new System.Drawing.Point(258, 245);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(218, 22);
            this.txtHoTen.TabIndex = 15;
            // 
            // cboSuKien
            // 
            this.cboSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cboSuKien.FormattingEnabled = true;
            this.cboSuKien.Location = new System.Drawing.Point(463, 110);
            this.cboSuKien.Margin = new System.Windows.Forms.Padding(2);
            this.cboSuKien.Name = "cboSuKien";
            this.cboSuKien.Size = new System.Drawing.Size(218, 24);
            this.cboSuKien.TabIndex = 19;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpNgaySinh.Location = new System.Drawing.Point(678, 174);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(221, 22);
            this.dtpNgaySinh.TabIndex = 20;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpNgayDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtpNgayDangKy.Location = new System.Drawing.Point(258, 279);
            this.dtpNgayDangKy.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Size = new System.Drawing.Size(218, 22);
            this.dtpNgayDangKy.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(678, 279);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(221, 22);
            this.txtEmail.TabIndex = 23;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSDT.Location = new System.Drawing.Point(678, 245);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(221, 22);
            this.txtSDT.TabIndex = 24;
            // 
            // dgvThamDu
            // 
            this.dgvThamDu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThamDu.Location = new System.Drawing.Point(96, 330);
            this.dgvThamDu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThamDu.Name = "dgvThamDu";
            this.dgvThamDu.RowHeadersWidth = 51;
            this.dgvThamDu.RowTemplate.Height = 24;
            this.dgvThamDu.Size = new System.Drawing.Size(803, 324);
            this.dgvThamDu.TabIndex = 25;
            this.dgvThamDu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThamDu_CellContentClick);
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtGioiTinh.Location = new System.Drawing.Point(678, 211);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(221, 22);
            this.txtGioiTinh.TabIndex = 26;
            this.txtGioiTinh.TextChanged += new System.EventHandler(this.txtGioiTinh_TextChanged);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSua.Location = new System.Drawing.Point(96, 676);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 29);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnXoa.Location = new System.Drawing.Point(232, 676);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 29);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDatLai
            // 
            this.btnDatLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDatLai.Location = new System.Drawing.Point(368, 676);
            this.btnDatLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(100, 29);
            this.btnDatLai.TabIndex = 30;
            this.btnDatLai.Text = "Đặt Lại";
            this.btnDatLai.UseVisualStyleBackColor = true;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnThoat.Location = new System.Drawing.Point(517, 676);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 29);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGuiMail
            // 
            this.btnGuiMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnGuiMail.Location = new System.Drawing.Point(650, 676);
            this.btnGuiMail.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuiMail.Name = "btnGuiMail";
            this.btnGuiMail.Size = new System.Drawing.Size(99, 29);
            this.btnGuiMail.TabIndex = 32;
            this.btnGuiMail.Text = "Gửi mail";
            this.btnGuiMail.UseVisualStyleBackColor = true;
            this.btnGuiMail.Click += new System.EventHandler(this.btnGuiMail_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.Location = new System.Drawing.Point(799, 676);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 29);
            this.button1.TabIndex = 33;
            this.button1.Text = "Xuất Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DanhSachNguoiThamDu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 1500);
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1038, 761);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuiMail);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDatLai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.dgvThamDu);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dtpNgayDangKy);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.cboSuKien);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtNDK);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaNTG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qldsntdsk);
            this.Name = "DanhSachNguoiThamDu";
            this.Text = "DanhSachNguoiThamDu";
            this.Load += new System.EventHandler(this.DanhSachNguoiThamDu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThamDu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label qldsntdsk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNTG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNDK;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cboSuKien;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DataGridView dgvThamDu;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnGuiMail;
        private System.Windows.Forms.Button button1;
    }
}