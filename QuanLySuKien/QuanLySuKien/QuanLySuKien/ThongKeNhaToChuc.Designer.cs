namespace QuanLySuKien
{
    partial class ThongKeNhaToChuc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.cboThoiGian = new System.Windows.Forms.ComboBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvThongKe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(19, 174);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(691, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Nhà tổ chức";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(18, 26);
            this.dgvThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 82;
            this.dgvThongKe.RowTemplate.Height = 33;
            this.dgvThongKe.Size = new System.Drawing.Size(660, 187);
            this.dgvThongKe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(249, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ NHÀ TỔ CHỨC";
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDong.Location = new System.Drawing.Point(19, 429);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Thoát";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // cboThoiGian
            // 
            this.cboThoiGian.FormattingEnabled = true;
            this.cboThoiGian.Location = new System.Drawing.Point(19, 125);
            this.cboThoiGian.Name = "cboThoiGian";
            this.cboThoiGian.Size = new System.Drawing.Size(121, 21);
            this.cboThoiGian.TabIndex = 3;
            this.cboThoiGian.SelectedIndexChanged += new System.EventHandler(this.cboThoiGian_SelectedIndexChanged);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(613, 428);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(75, 23);
            this.btnXuatExcel.TabIndex = 4;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // ThongKeNhaToChuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(736, 494);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.cboThoiGian);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ThongKeNhaToChuc";
            this.Text = "ThongKeNhaToChuc";
            this.Load += new System.EventHandler(this.ThongKeNhaToChuc_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ComboBox cboThoiGian;
        private System.Windows.Forms.Button btnXuatExcel;
    }
}