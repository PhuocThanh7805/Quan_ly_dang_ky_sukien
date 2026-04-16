namespace QuanLySuKien
{
    partial class FormDangKi
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
            this.DangNhap = new System.Windows.Forms.Label();
            this.lblMaNDK = new System.Windows.Forms.Label();
            this.lblTenNDK = new System.Windows.Forms.Label();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblNhapLai = new System.Windows.Forms.Label();
            this.txtMaNDK = new System.Windows.Forms.TextBox();
            this.txtTenNDK = new System.Windows.Forms.TextBox();
            this.dtpNamSinh = new System.Windows.Forms.DateTimePicker();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DangNhap
            // 
            this.DangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhap.Location = new System.Drawing.Point(0, 0);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(800, 109);
            this.DangNhap.TabIndex = 0;
            this.DangNhap.Text = "ĐĂNG KÝ";
            this.DangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaNDK
            // 
            this.lblMaNDK.AutoSize = true;
            this.lblMaNDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMaNDK.Location = new System.Drawing.Point(207, 126);
            this.lblMaNDK.Name = "lblMaNDK";
            this.lblMaNDK.Size = new System.Drawing.Size(129, 16);
            this.lblMaNDK.TabIndex = 1;
            this.lblMaNDK.Text = "Mã người đăng ký";
            // 
            // lblTenNDK
            // 
            this.lblTenNDK.AutoSize = true;
            this.lblTenNDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTenNDK.Location = new System.Drawing.Point(207, 165);
            this.lblTenNDK.Name = "lblTenNDK";
            this.lblTenNDK.Size = new System.Drawing.Size(58, 16);
            this.lblTenNDK.TabIndex = 2;
            this.lblTenNDK.Text = "Họ Tên";
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNamSinh.Location = new System.Drawing.Point(207, 205);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(71, 16);
            this.lblNamSinh.TabIndex = 3;
            this.lblNamSinh.Text = "Năm sinh";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(207, 246);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 16);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(207, 290);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 16);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lblNhapLai
            // 
            this.lblNhapLai.AutoSize = true;
            this.lblNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNhapLai.Location = new System.Drawing.Point(207, 327);
            this.lblNhapLai.Name = "lblNhapLai";
            this.lblNhapLai.Size = new System.Drawing.Size(131, 16);
            this.lblNhapLai.TabIndex = 6;
            this.lblNhapLai.Text = "Nhập lại mật khẩu";
            // 
            // txtMaNDK
            // 
            this.txtMaNDK.Location = new System.Drawing.Point(360, 122);
            this.txtMaNDK.Name = "txtMaNDK";
            this.txtMaNDK.Size = new System.Drawing.Size(200, 20);
            this.txtMaNDK.TabIndex = 7;
            // 
            // txtTenNDK
            // 
            this.txtTenNDK.Location = new System.Drawing.Point(360, 161);
            this.txtTenNDK.Name = "txtTenNDK";
            this.txtTenNDK.Size = new System.Drawing.Size(200, 20);
            this.txtTenNDK.TabIndex = 8;
            // 
            // dtpNamSinh
            // 
            this.dtpNamSinh.Location = new System.Drawing.Point(360, 201);
            this.dtpNamSinh.Name = "dtpNamSinh";
            this.dtpNamSinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNamSinh.TabIndex = 9;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(360, 242);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(360, 286);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(360, 323);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(200, 20);
            this.txtNhapLaiMatKhau.TabIndex = 12;
            this.txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangKi
            // 
            this.btnDangKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDangKi.Location = new System.Drawing.Point(264, 396);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(103, 29);
            this.btnDangKi.TabIndex = 13;
            this.btnDangKi.Text = "Đăng ký";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnThoat.Location = new System.Drawing.Point(404, 396);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormDangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.txtNhapLaiMatKhau);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.dtpNamSinh);
            this.Controls.Add(this.txtTenNDK);
            this.Controls.Add(this.txtMaNDK);
            this.Controls.Add(this.lblNhapLai);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblNamSinh);
            this.Controls.Add(this.lblTenNDK);
            this.Controls.Add(this.lblMaNDK);
            this.Controls.Add(this.DangNhap);
            this.Name = "FormDangKi";
            this.Text = "FormDangKi";
            this.Load += new System.EventHandler(this.FormDangKi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DangNhap;
        private System.Windows.Forms.Label lblMaNDK;
        private System.Windows.Forms.Label lblTenNDK;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblNhapLai;
        private System.Windows.Forms.TextBox txtMaNDK;
        private System.Windows.Forms.TextBox txtTenNDK;
        private System.Windows.Forms.DateTimePicker dtpNamSinh;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Button btnThoat;
    }
}