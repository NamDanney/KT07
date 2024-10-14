namespace De01
{
    partial class frmSinhvien
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
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVSinhVien = new System.Windows.Forms.DataGridView();
            this.Col_MSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btKhong = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btTim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSinhVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.txtHoTenSV);
            this.groupBox1.Controls.Add(this.dtNgaySinh);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(103, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(905, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN CHI TIẾT";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(547, 100);
            this.cboLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(229, 24);
            this.cboLop.TabIndex = 7;
            // 
            // txtHoTenSV
            // 
            this.txtHoTenSV.Location = new System.Drawing.Point(547, 37);
            this.txtHoTenSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtHoTenSV.Size = new System.Drawing.Size(229, 22);
            this.txtHoTenSV.TabIndex = 6;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(137, 100);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(265, 22);
            this.dtNgaySinh.TabIndex = 5;
            this.dtNgaySinh.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(137, 37);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(197, 22);
            this.txtMaSV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lớp học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // DGVSinhVien
            // 
            this.DGVSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_MSV,
            this.Col_HoTen,
            this.Col_DATE,
            this.Col_Lop});
            this.DGVSinhVien.Location = new System.Drawing.Point(83, 332);
            this.DGVSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVSinhVien.Name = "DGVSinhVien";
            this.DGVSinhVien.Size = new System.Drawing.Size(977, 302);
            this.DGVSinhVien.TabIndex = 1;
            this.DGVSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSinhVien_CellContentClick);
            // 
            // Col_MSV
            // 
            this.Col_MSV.HeaderText = "Mã SV";
            this.Col_MSV.Name = "Col_MSV";
            // 
            // Col_HoTen
            // 
            this.Col_HoTen.HeaderText = "Họ và tên";
            this.Col_HoTen.Name = "Col_HoTen";
            // 
            // Col_DATE
            // 
            this.Col_DATE.HeaderText = "Ngày sinh";
            this.Col_DATE.Name = "Col_DATE";
            // 
            // Col_Lop
            // 
            this.Col_Lop.HeaderText = "Lớp";
            this.Col_Lop.Name = "Col_Lop";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btKhong);
            this.groupBox2.Controls.Add(this.btLuu);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Location = new System.Drawing.Point(368, 242);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(640, 68);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(488, 22);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(88, 38);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btKhong
            // 
            this.btKhong.Enabled = false;
            this.btKhong.Location = new System.Drawing.Point(392, 22);
            this.btKhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btKhong.Name = "btKhong";
            this.btKhong.Size = new System.Drawing.Size(88, 38);
            this.btKhong.TabIndex = 4;
            this.btKhong.Text = "K.Lưu";
            this.btKhong.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Enabled = false;
            this.btLuu.Location = new System.Drawing.Point(296, 22);
            this.btLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(88, 38);
            this.btLuu.TabIndex = 3;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(200, 22);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(88, 38);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(104, 22);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(88, 38);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(8, 22);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(88, 38);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(84, 272);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(132, 22);
            this.txtTim.TabIndex = 3;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(225, 265);
            this.btTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(88, 38);
            this.btTim.TabIndex = 6;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // frmSinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 649);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DGVSinhVien);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSinhvien";
            this.Text = "DANH SÁCH SINH VIÊN";
            this.Load += new System.EventHandler(this.frmSinhvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSinhVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btKhong;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtTim;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Lop;
    }
}

