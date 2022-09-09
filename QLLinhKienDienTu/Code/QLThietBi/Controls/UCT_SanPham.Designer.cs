namespace Controls
{
    partial class UCT_SanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCT_SanPham));
            this.txtSl = new System.Windows.Forms.NumericUpDown();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblTenTB = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.pbHinhAnh = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtSl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSl
            // 
            this.txtSl.Location = new System.Drawing.Point(294, 66);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(120, 30);
            this.txtSl.TabIndex = 11;
            // 
            // btnBuy
            // 
            this.btnBuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuy.BackgroundImage")));
            this.btnBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuy.Location = new System.Drawing.Point(452, 47);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(92, 66);
            this.btnBuy.TabIndex = 10;
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblTenTB
            // 
            this.lblTenTB.AutoSize = true;
            this.lblTenTB.ForeColor = System.Drawing.Color.Blue;
            this.lblTenTB.Location = new System.Drawing.Point(295, 27);
            this.lblTenTB.Name = "lblTenTB";
            this.lblTenTB.Size = new System.Drawing.Size(102, 25);
            this.lblTenTB.TabIndex = 5;
            this.lblTenTB.Text = "Thiết bị 1";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(160, 68);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(112, 25);
            this.lblSL.TabIndex = 6;
            this.lblSL.Text = "Số Lượng:";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.ForeColor = System.Drawing.Color.Red;
            this.lblGiaTien.Location = new System.Drawing.Point(295, 111);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(108, 25);
            this.lblGiaTien.TabIndex = 7;
            this.lblGiaTien.Text = "00000000";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(160, 108);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(52, 25);
            this.lblGia.TabIndex = 8;
            this.lblGia.Text = "Giá:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(160, 27);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(57, 25);
            this.lblTen.TabIndex = 9;
            this.lblTen.Text = "Tên:";
            // 
            // pbHinhAnh
            // 
            this.pbHinhAnh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHinhAnh.BackgroundImage")));
            this.pbHinhAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHinhAnh.Location = new System.Drawing.Point(20, 19);
            this.pbHinhAnh.Name = "pbHinhAnh";
            this.pbHinhAnh.Size = new System.Drawing.Size(120, 118);
            this.pbHinhAnh.TabIndex = 4;
            this.pbHinhAnh.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbHinhAnh);
            this.panel1.Controls.Add(this.txtSl);
            this.panel1.Controls.Add(this.lblTen);
            this.panel1.Controls.Add(this.btnBuy);
            this.panel1.Controls.Add(this.lblGia);
            this.panel1.Controls.Add(this.lblTenTB);
            this.panel1.Controls.Add(this.lblGiaTien);
            this.panel1.Controls.Add(this.lblSL);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 170);
            this.panel1.TabIndex = 12;
            // 
            // UCT_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCT_SanPham";
            this.Size = new System.Drawing.Size(1145, 698);
            this.Load += new System.EventHandler(this.UCT_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtSl;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblTenTB;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.PictureBox pbHinhAnh;
        private System.Windows.Forms.Panel panel1;

    }
}
