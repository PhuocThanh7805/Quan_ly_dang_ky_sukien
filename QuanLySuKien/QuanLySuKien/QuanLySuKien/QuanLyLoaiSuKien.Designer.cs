namespace QuanLySuKien
{
    partial class QuanLyLoaiSuKien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLoaiSuKien = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSuKien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(75, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(75, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên loại";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(75, 343);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(175, 343);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(275, 343);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLoaiSuKien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(432, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 246);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgvLoaiSuKien
            // 
            this.dgvLoaiSuKien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiSuKien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiSuKien.Location = new System.Drawing.Point(3, 18);
            this.dgvLoaiSuKien.Name = "dgvLoaiSuKien";
            this.dgvLoaiSuKien.Size = new System.Drawing.Size(387, 225);
            this.dgvLoaiSuKien.TabIndex = 0;
            this.dgvLoaiSuKien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSuKien_CellClick);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(913, 81);
            this.label4.TabIndex = 10;
            this.label4.Text = "QUẢN LÝ LOẠI SỰ KIỆN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(624, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tìm kiếm";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Enabled = false;
            this.txtMaLoai.Location = new System.Drawing.Point(175, 198);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(100, 20);
            this.txtMaLoai.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(692, 118);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(100, 20);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(175, 248);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(200, 20);
            this.txtTenLoai.TabIndex = 13;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDong.Location = new System.Drawing.Point(175, 406);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 33);
            this.btnDong.TabIndex = 14;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // QuanLyLoaiSuKien
            // 
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(913, 584);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTimKiem);
            this.Name = "QuanLyLoaiSuKien";
            this.Text = "QuanLyLoaiSuKien";
            this.Load += new System.EventHandler(this.QuanLyLoaiSuKien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSuKien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLoaiSuKien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Button btnDong;
    }
}