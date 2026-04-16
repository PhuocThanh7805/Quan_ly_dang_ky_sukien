namespace QuanLySuKien
{
    partial class TrangChuNguoiDangKy
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
            this.lblXinChao = new System.Windows.Forms.Label();
            this.btnDanhSachSuKien = new System.Windows.Forms.Button();
            this.btnCapNhatThongTin = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblXinChao
            // 
            this.lblXinChao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblXinChao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChao.Location = new System.Drawing.Point(0, 0);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(800, 94);
            this.lblXinChao.TabIndex = 0;
            this.lblXinChao.Text = "Xin chào";
            this.lblXinChao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDanhSachSuKien
            // 
            this.btnDanhSachSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDanhSachSuKien.Location = new System.Drawing.Point(309, 159);
            this.btnDanhSachSuKien.Name = "btnDanhSachSuKien";
            this.btnDanhSachSuKien.Size = new System.Drawing.Size(158, 32);
            this.btnDanhSachSuKien.TabIndex = 1;
            this.btnDanhSachSuKien.Text = "Danh sách sự kiện";
            this.btnDanhSachSuKien.UseVisualStyleBackColor = true;
            this.btnDanhSachSuKien.Click += new System.EventHandler(this.btnDanhSachSuKien_Click);
            // 
            // btnCapNhatThongTin
            // 
            this.btnCapNhatThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCapNhatThongTin.Location = new System.Drawing.Point(309, 215);
            this.btnCapNhatThongTin.Name = "btnCapNhatThongTin";
            this.btnCapNhatThongTin.Size = new System.Drawing.Size(158, 32);
            this.btnCapNhatThongTin.TabIndex = 2;
            this.btnCapNhatThongTin.Text = "Cập nhật thông tin";
            this.btnCapNhatThongTin.UseVisualStyleBackColor = true;
            this.btnCapNhatThongTin.Click += new System.EventHandler(this.btnCapNhatThongTin_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDangXuat.Location = new System.Drawing.Point(352, 284);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(75, 29);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // TrangChuNguoiDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnCapNhatThongTin);
            this.Controls.Add(this.btnDanhSachSuKien);
            this.Controls.Add(this.lblXinChao);
            this.Name = "TrangChuNguoiDangKy";
            this.Text = "TrangChuNguoiDangKy";
            this.Load += new System.EventHandler(this.TrangChuNguoiDangKy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblXinChao;
        private System.Windows.Forms.Button btnDanhSachSuKien;
        private System.Windows.Forms.Button btnCapNhatThongTin;
        private System.Windows.Forms.Button btnDangXuat;
    }
}