namespace QuanLySuKien
{
    partial class CapNhatTrangThai
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
            this.cnttsk = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ccbTrangThaiSK = new System.Windows.Forms.ComboBox();
            this.btn_LuuTrangThai = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // cnttsk
            // 
            this.cnttsk.Dock = System.Windows.Forms.DockStyle.Top;
            this.cnttsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnttsk.Location = new System.Drawing.Point(0, 0);
            this.cnttsk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cnttsk.Name = "cnttsk";
            this.cnttsk.Size = new System.Drawing.Size(1193, 132);
            this.cnttsk.TabIndex = 0;
            this.cnttsk.Text = "CẬP NHẬT TRẠNG THÁI SỰ KIỆN";
            this.cnttsk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(77, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sự kiện:";
            // 
            // txtTenSK
            // 
            this.txtTenSK.Location = new System.Drawing.Point(228, 196);
            this.txtTenSK.Name = "txtTenSK";
            this.txtTenSK.ReadOnly = true;
            this.txtTenSK.Size = new System.Drawing.Size(216, 19);
            this.txtTenSK.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(77, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trạng thái:";
            // 
            // ccbTrangThaiSK
            // 
            this.ccbTrangThaiSK.FormattingEnabled = true;
            this.ccbTrangThaiSK.Location = new System.Drawing.Point(228, 243);
            this.ccbTrangThaiSK.Name = "ccbTrangThaiSK";
            this.ccbTrangThaiSK.Size = new System.Drawing.Size(216, 21);
            this.ccbTrangThaiSK.TabIndex = 4;
            // 
            // btn_LuuTrangThai
            // 
            this.btn_LuuTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_LuuTrangThai.Location = new System.Drawing.Point(144, 305);
            this.btn_LuuTrangThai.Name = "btn_LuuTrangThai";
            this.btn_LuuTrangThai.Size = new System.Drawing.Size(75, 31);
            this.btn_LuuTrangThai.TabIndex = 6;
            this.btn_LuuTrangThai.Text = "Lưu";
            this.btn_LuuTrangThai.UseVisualStyleBackColor = true;
            this.btn_LuuTrangThai.Click += new System.EventHandler(this.btn_LuuTrangThai_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_Huy.Location = new System.Drawing.Point(252, 305);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 31);
            this.btn_Huy.TabIndex = 7;
            this.btn_Huy.Text = "Thoát";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLichSu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(514, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 230);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch sử cập nhật trạng thái";
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Location = new System.Drawing.Point(24, 30);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.RowHeadersWidth = 51;
            this.dgvLichSu.RowTemplate.Height = 24;
            this.dgvLichSu.Size = new System.Drawing.Size(594, 172);
            this.dgvLichSu.TabIndex = 0;
            // 
            // CapNhatTrangThai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1193, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_LuuTrangThai);
            this.Controls.Add(this.ccbTrangThaiSK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenSK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cnttsk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CapNhatTrangThai";
            this.Text = "CapNhatTrangThaiSuKien";
            this.Load += new System.EventHandler(this.CapNhatTrangThai_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cnttsk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ccbTrangThaiSK;
        private System.Windows.Forms.Button btn_LuuTrangThai;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLichSu;
    }
}