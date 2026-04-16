namespace QuanLySuKien
{
    partial class FormDangNhap
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
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.lnkDangKy = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // DangNhap
            // 
            this.DangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhap.Location = new System.Drawing.Point(0, 0);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(800, 116);
            this.DangNhap.TabIndex = 0;
            this.DangNhap.Text = "ĐĂNG NHẬP";
            this.DangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Username.Location = new System.Drawing.Point(286, 158);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(78, 16);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Password.Location = new System.Drawing.Point(286, 208);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(75, 16);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(375, 154);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(133, 20);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(375, 204);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(133, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDangNhap.Location = new System.Drawing.Point(289, 284);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(91, 33);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnHuyBo.Location = new System.Drawing.Point(424, 284);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHuyBo.Size = new System.Drawing.Size(84, 33);
            this.btnHuyBo.TabIndex = 6;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // lnkDangKy
            // 
            this.lnkDangKy.AutoSize = true;
            this.lnkDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lnkDangKy.Location = new System.Drawing.Point(372, 340);
            this.lnkDangKy.Name = "lnkDangKy";
            this.lnkDangKy.Size = new System.Drawing.Size(52, 16);
            this.lnkDangKy.TabIndex = 7;
            this.lnkDangKy.TabStop = true;
            this.lnkDangKy.Text = "Đăng kí";
            this.lnkDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDangKy_LinkClicked);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.lnkDangKy);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.DangNhap);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DangNhap;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.LinkLabel lnkDangKy;
    }
}