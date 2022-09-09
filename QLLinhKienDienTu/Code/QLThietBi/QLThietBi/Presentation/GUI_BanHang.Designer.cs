namespace QLThietBi.Presentation
{
    partial class GUI_BanHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbSanPham = new System.Windows.Forms.GroupBox();
            this.dtgSanPham = new System.Windows.Forms.DataGridView();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbKH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.NumericUpDown();
            this.btnDat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.chkTraGop = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSChon = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbGia = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.pcbAnhTB = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnCTDonHang = new System.Windows.Forms.Button();
            this.btnHuyHoaDon = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.chkALLSP = new System.Windows.Forms.CheckBox();
            this.grbSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnhTB)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANG CHỦ - BÁN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbSanPham
            // 
            this.grbSanPham.Controls.Add(this.dtgSanPham);
            this.grbSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSanPham.Location = new System.Drawing.Point(91, 162);
            this.grbSanPham.Name = "grbSanPham";
            this.grbSanPham.Size = new System.Drawing.Size(670, 304);
            this.grbSanPham.TabIndex = 4;
            this.grbSanPham.TabStop = false;
            this.grbSanPham.Text = "Sản phẩm";
            // 
            // dtgSanPham
            // 
            this.dtgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSanPham.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgSanPham.Location = new System.Drawing.Point(21, 31);
            this.dtgSanPham.Name = "dtgSanPham";
            this.dtgSanPham.RowTemplate.Height = 24;
            this.dtgSanPham.Size = new System.Drawing.Size(632, 253);
            this.dtgSanPham.TabIndex = 0;
            this.dtgSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSanPham_CellClick);
            // 
            // cbbLoai
            // 
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Location = new System.Drawing.Point(262, 105);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(198, 33);
            this.cbbLoai.TabIndex = 0;
            this.cbbLoai.SelectedIndexChanged += new System.EventHandler(this.cbbLoai_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại Sản Phẩm:";
            // 
            // cbbKH
            // 
            this.cbbKH.FormattingEnabled = true;
            this.cbbKH.Location = new System.Drawing.Point(191, 67);
            this.cbbKH.Name = "cbbKH";
            this.cbbKH.Size = new System.Drawing.Size(198, 33);
            this.cbbKH.TabIndex = 0;
            this.cbbKH.SelectedIndexChanged += new System.EventHandler(this.cbbLoai_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Khách Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ảnh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số Lượng:";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(191, 302);
            this.txtSL.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(113, 30);
            this.txtSL.TabIndex = 7;
            // 
            // btnDat
            // 
            this.btnDat.BackColor = System.Drawing.Color.LightGray;
            this.btnDat.ForeColor = System.Drawing.Color.Black;
            this.btnDat.Location = new System.Drawing.Point(1275, 206);
            this.btnDat.Name = "btnDat";
            this.btnDat.Size = new System.Drawing.Size(176, 68);
            this.btnDat.TabIndex = 10;
            this.btnDat.Text = "Mua";
            this.btnDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDat.UseVisualStyleBackColor = false;
            this.btnDat.Click += new System.EventHandler(this.btnDat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hình Thức:";
            // 
            // chkTraGop
            // 
            this.chkTraGop.AutoSize = true;
            this.chkTraGop.Location = new System.Drawing.Point(191, 376);
            this.chkTraGop.Name = "chkTraGop";
            this.chkTraGop.Size = new System.Drawing.Size(106, 29);
            this.chkTraGop.TabIndex = 11;
            this.chkTraGop.Text = "Trả Góp";
            this.chkTraGop.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSChon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(91, 485);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 284);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dgvDSChon
            // 
            this.dgvDSChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSChon.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSChon.Location = new System.Drawing.Point(21, 41);
            this.dgvDSChon.Name = "dgvDSChon";
            this.dgvDSChon.RowTemplate.Height = 24;
            this.dgvDSChon.Size = new System.Drawing.Size(632, 237);
            this.dgvDSChon.TabIndex = 0;
            this.dgvDSChon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsChon_CellClick);
            this.dgvDSChon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSChon_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(529, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tìm Kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(704, 105);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(240, 30);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cbbGia
            // 
            this.cbbGia.FormattingEnabled = true;
            this.cbbGia.Location = new System.Drawing.Point(1139, 102);
            this.cbbGia.Name = "cbbGia";
            this.cbbGia.Size = new System.Drawing.Size(198, 33);
            this.cbbGia.TabIndex = 0;
            this.cbbGia.SelectedIndexChanged += new System.EventHandler(this.cbbGia_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1035, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Giá:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Thành Tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(191, 470);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(211, 30);
            this.txtThanhTien.TabIndex = 12;
            // 
            // pcbAnhTB
            // 
            this.pcbAnhTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbAnhTB.ErrorImage = null;
            this.pcbAnhTB.Location = new System.Drawing.Point(191, 125);
            this.pcbAnhTB.Name = "pcbAnhTB";
            this.pcbAnhTB.Size = new System.Drawing.Size(150, 150);
            this.pcbAnhTB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAnhTB.TabIndex = 8;
            this.pcbAnhTB.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbKH);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chkTraGop);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSL);
            this.groupBox2.Controls.Add(this.pcbAnhTB);
            this.groupBox2.Location = new System.Drawing.Point(803, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 607);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.LightGray;
            this.btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan.Location = new System.Drawing.Point(1275, 613);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(176, 68);
            this.btnThanhToan.TabIndex = 10;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnCTDonHang
            // 
            this.btnCTDonHang.BackColor = System.Drawing.Color.LightGray;
            this.btnCTDonHang.ForeColor = System.Drawing.Color.Black;
            this.btnCTDonHang.Location = new System.Drawing.Point(1275, 499);
            this.btnCTDonHang.Name = "btnCTDonHang";
            this.btnCTDonHang.Size = new System.Drawing.Size(176, 68);
            this.btnCTDonHang.TabIndex = 10;
            this.btnCTDonHang.Text = "Hủy Mua";
            this.btnCTDonHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCTDonHang.UseVisualStyleBackColor = false;
            this.btnCTDonHang.Click += new System.EventHandler(this.btnHuyCTDonHang_Click);
            // 
            // btnHuyHoaDon
            // 
            this.btnHuyHoaDon.BackColor = System.Drawing.Color.LightGray;
            this.btnHuyHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnHuyHoaDon.Location = new System.Drawing.Point(1275, 398);
            this.btnHuyHoaDon.Name = "btnHuyHoaDon";
            this.btnHuyHoaDon.Size = new System.Drawing.Size(176, 68);
            this.btnHuyHoaDon.TabIndex = 10;
            this.btnHuyHoaDon.Text = "Hủy Hóa Đơn";
            this.btnHuyHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuyHoaDon.UseVisualStyleBackColor = false;
            this.btnHuyHoaDon.Click += new System.EventHandler(this.btnHuyDon_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightGray;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(1275, 301);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(176, 68);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // chkALLSP
            // 
            this.chkALLSP.AutoSize = true;
            this.chkALLSP.Location = new System.Drawing.Point(1360, 109);
            this.chkALLSP.Name = "chkALLSP";
            this.chkALLSP.Size = new System.Drawing.Size(89, 29);
            this.chkALLSP.TabIndex = 14;
            this.chkALLSP.Text = "Tất cả";
            this.chkALLSP.UseVisualStyleBackColor = true;
            this.chkALLSP.Click += new System.EventHandler(this.chkALLSP_Click);
            // 
            // GUI_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1518, 781);
            this.Controls.Add(this.chkALLSP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnHuyHoaDon);
            this.Controls.Add(this.btnCTDonHang);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnDat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbGia);
            this.Controls.Add(this.cbbLoai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbSanPham);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI_BanHang";
            this.Text = "GUI_DonHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GUI_DonHang_Load);
            this.grbSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAnhTB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbSanPham;
        private System.Windows.Forms.DataGridView dtgSanPham;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtSL;
        private System.Windows.Forms.PictureBox pcbAnhTB;
        private System.Windows.Forms.Button btnDat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkTraGop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSChon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbbGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnCTDonHang;
        private System.Windows.Forms.Button btnHuyHoaDon;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.CheckBox chkALLSP;
    }
}