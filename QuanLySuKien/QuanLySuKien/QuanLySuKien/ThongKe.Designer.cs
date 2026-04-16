namespace QuanLySuKien
{
    partial class ThongKe
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
            this.dgvThongKeChung = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvFullGhe = new System.Windows.Forms.DataGridView();
            this.dgvDangDienRa = new System.Windows.Forms.DataGridView();
            this.txtTongSK = new System.Windows.Forms.TextBox();
            this.txtMaxSK = new System.Windows.Forms.TextBox();
            this.txtMinSK = new System.Windows.Forms.TextBox();
            this.lblFullGheCount = new System.Windows.Forms.Label();
            this.cboThoiGian = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeChung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFullGhe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangDienRa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongKeChung
            // 
            this.dgvThongKeChung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeChung.Location = new System.Drawing.Point(47, 621);
            this.dgvThongKeChung.Name = "dgvThongKeChung";
            this.dgvThongKeChung.RowHeadersWidth = 51;
            this.dgvThongKeChung.RowTemplate.Height = 24;
            this.dgvThongKeChung.Size = new System.Drawing.Size(988, 232);
            this.dgvThongKeChung.TabIndex = 0;
            this.dgvThongKeChung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongKe_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(44, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn thời gian thống kê:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(600, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng sự kiện full ghế:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(21, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sự kiện đông người tham gia nhất:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(600, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tổng số sự kiện:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(22, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sự kiện đang diễn ra:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(22, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sự kiện ít người tham gia nhất:";
            // 
            // dgvFullGhe
            // 
            this.dgvFullGhe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFullGhe.Location = new System.Drawing.Point(603, 111);
            this.dgvFullGhe.Name = "dgvFullGhe";
            this.dgvFullGhe.RowHeadersWidth = 51;
            this.dgvFullGhe.RowTemplate.Height = 24;
            this.dgvFullGhe.Size = new System.Drawing.Size(410, 181);
            this.dgvFullGhe.TabIndex = 9;
            // 
            // dgvDangDienRa
            // 
            this.dgvDangDienRa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangDienRa.Location = new System.Drawing.Point(25, 155);
            this.dgvDangDienRa.Name = "dgvDangDienRa";
            this.dgvDangDienRa.RowHeadersWidth = 51;
            this.dgvDangDienRa.RowTemplate.Height = 24;
            this.dgvDangDienRa.Size = new System.Drawing.Size(475, 137);
            this.dgvDangDienRa.TabIndex = 10;
            // 
            // txtTongSK
            // 
            this.txtTongSK.Location = new System.Drawing.Point(738, 39);
            this.txtTongSK.Name = "txtTongSK";
            this.txtTongSK.Size = new System.Drawing.Size(136, 27);
            this.txtTongSK.TabIndex = 11;
            // 
            // txtMaxSK
            // 
            this.txtMaxSK.Location = new System.Drawing.Point(288, 46);
            this.txtMaxSK.Name = "txtMaxSK";
            this.txtMaxSK.Size = new System.Drawing.Size(239, 27);
            this.txtMaxSK.TabIndex = 12;
            // 
            // txtMinSK
            // 
            this.txtMinSK.Location = new System.Drawing.Point(288, 88);
            this.txtMinSK.Name = "txtMinSK";
            this.txtMinSK.Size = new System.Drawing.Size(239, 27);
            this.txtMinSK.TabIndex = 13;
            this.txtMinSK.TextChanged += new System.EventHandler(this.txtMinSK_TextChanged);
            // 
            // lblFullGheCount
            // 
            this.lblFullGheCount.AutoSize = true;
            this.lblFullGheCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblFullGheCount.Location = new System.Drawing.Point(802, 88);
            this.lblFullGheCount.Name = "lblFullGheCount";
            this.lblFullGheCount.Size = new System.Drawing.Size(32, 20);
            this.lblFullGheCount.TabIndex = 15;
            this.lblFullGheCount.Text = "số ";
            // 
            // cboThoiGian
            // 
            this.cboThoiGian.FormattingEnabled = true;
            this.cboThoiGian.Items.AddRange(new object[] {
            "Tất cả",
            "Hôm nay",
            "Tháng này",
            "Năm nay"});
            this.cboThoiGian.Location = new System.Drawing.Point(221, 96);
            this.cboThoiGian.Name = "cboThoiGian";
            this.cboThoiGian.Size = new System.Drawing.Size(136, 26);
            this.cboThoiGian.TabIndex = 16;
            this.cboThoiGian.SelectedIndexChanged += new System.EventHandler(this.cboThoiGian_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFullGheCount);
            this.groupBox1.Controls.Add(this.txtMinSK);
            this.groupBox1.Controls.Add(this.txtMaxSK);
            this.groupBox1.Controls.Add(this.txtTongSK);
            this.groupBox1.Controls.Add(this.dgvDangDienRa);
            this.groupBox1.Controls.Add(this.dgvFullGhe);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 357);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN CHUNG";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(445, 572);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "TỔNG QUAN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(445, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(256, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "THỐNG KÊ SỰ KIÊN";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(787, 552);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(189, 40);
            this.btnXuatExcel.TabIndex = 20;
            this.btnXuatExcel.Text = "XUẤT EXCEL";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnThoat.Location = new System.Drawing.Point(47, 552);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 26);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 1000);
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1070, 884);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboThoiGian);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThongKeChung);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeChung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFullGhe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangDienRa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongKeChung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvFullGhe;
        private System.Windows.Forms.DataGridView dgvDangDienRa;
        private System.Windows.Forms.TextBox txtTongSK;
        private System.Windows.Forms.TextBox txtMaxSK;
        private System.Windows.Forms.TextBox txtMinSK;
        private System.Windows.Forms.Label lblFullGheCount;
        private System.Windows.Forms.ComboBox cboThoiGian;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnThoat;
    }
}