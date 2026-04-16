namespace QuanLySuKien
{
    partial class TrangChuAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnQuanLySuKien = new System.Windows.Forms.Button();
            this.btnQuanLyLoaiSuKien = new System.Windows.Forms.Button();
            this.btnQuanLyNhaToChuc = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuanLySuKien
            // 
            this.btnQuanLySuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnQuanLySuKien.Location = new System.Drawing.Point(326, 168);
            this.btnQuanLySuKien.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuanLySuKien.Name = "btnQuanLySuKien";
            this.btnQuanLySuKien.Size = new System.Drawing.Size(150, 28);
            this.btnQuanLySuKien.TabIndex = 1;
            this.btnQuanLySuKien.Text = "Quản lý sự kiện";
            this.btnQuanLySuKien.UseVisualStyleBackColor = true;
            this.btnQuanLySuKien.Click += new System.EventHandler(this.btnQuanLySuKien_Click);
            // 
            // btnQuanLyLoaiSuKien
            // 
            this.btnQuanLyLoaiSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnQuanLyLoaiSuKien.Location = new System.Drawing.Point(326, 209);
            this.btnQuanLyLoaiSuKien.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuanLyLoaiSuKien.Name = "btnQuanLyLoaiSuKien";
            this.btnQuanLyLoaiSuKien.Size = new System.Drawing.Size(150, 28);
            this.btnQuanLyLoaiSuKien.TabIndex = 2;
            this.btnQuanLyLoaiSuKien.Text = "Quản lý loại sự kiện";
            this.btnQuanLyLoaiSuKien.UseVisualStyleBackColor = true;
            this.btnQuanLyLoaiSuKien.Click += new System.EventHandler(this.btnQuanLyLoaiSuKien_Click);
            // 
            // btnQuanLyNhaToChuc
            // 
            this.btnQuanLyNhaToChuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnQuanLyNhaToChuc.Location = new System.Drawing.Point(326, 250);
            this.btnQuanLyNhaToChuc.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuanLyNhaToChuc.Name = "btnQuanLyNhaToChuc";
            this.btnQuanLyNhaToChuc.Size = new System.Drawing.Size(150, 28);
            this.btnQuanLyNhaToChuc.TabIndex = 3;
            this.btnQuanLyNhaToChuc.Text = "Quản lý nhà tổ chức";
            this.btnQuanLyNhaToChuc.UseVisualStyleBackColor = true;
            this.btnQuanLyNhaToChuc.Click += new System.EventHandler(this.btnQuanLyNhaToChuc_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDangXuat.Location = new System.Drawing.Point(361, 331);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(81, 28);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(234, 53);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ SỰ KIỆN";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnThongKe.Location = new System.Drawing.Point(326, 290);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(150, 28);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // TrangChuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnQuanLyNhaToChuc);
            this.Controls.Add(this.btnQuanLyLoaiSuKien);
            this.Controls.Add(this.btnQuanLySuKien);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TrangChuAdmin";
            this.Text = "TrangChuAdmin";
            this.Load += new System.EventHandler(this.TrangChuAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnQuanLySuKien;
        private System.Windows.Forms.Button btnQuanLyLoaiSuKien;
        private System.Windows.Forms.Button btnQuanLyNhaToChuc;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnThongKe;
    }
}