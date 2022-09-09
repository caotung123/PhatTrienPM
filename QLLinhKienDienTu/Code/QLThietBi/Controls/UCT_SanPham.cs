using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class UCT_SanPham : UserControl
    {
    

        public UCT_SanPham()
        {
            InitializeComponent();
        }
        public UCT_SanPham(PictureBox pbHinhAnh, Label lblTen, Label lblSL, Label lblGia, Label lblTenTB, NumericUpDown txtSl, Label lblGiaTien, Button btnBuy)
        {
            InitializeComponent();

            this.pbHinhAnh = pbHinhAnh;
            this.lblTen = lblTen;
            this.lblSL = lblSL;
            this.lblGia = lblGia;
            this.lblTenTB = lblTenTB;
            this.txtSl = txtSl;
            this.lblGiaTien = lblGiaTien;
            this.lblGiaTien = lblGiaTien;
            this.btnBuy = btnBuy;
            lblTenTB.Text = "TB 1";
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            lblTenTB.Text = "TB 1";
            MessageBox.Show("" + lblTenTB.Text);
        }

        private void UCT_SanPham_Load(object sender, EventArgs e)
        {

        }

        void taoUCControls()
        {
            // 
            // txtSl
            // 
            txtSl.Location = new System.Drawing.Point(294, 66);
            txtSl.Name = "txtSl";
            txtSl.Size = new System.Drawing.Size(120, 30);
            txtSl.TabIndex = 11;
            // 
            // btnBuy
            // 
            //btnBuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuy.BackgroundImage")));
            btnBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnBuy.Location = new System.Drawing.Point(452, 47);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new System.Drawing.Size(92, 66);
            btnBuy.TabIndex = 10;
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += new System.EventHandler(btnBuy_Click);
            // 
            // lblTenTB
            // 
            lblTenTB.AutoSize = true;
            lblTenTB.ForeColor = System.Drawing.Color.Blue;
            lblTenTB.Location = new System.Drawing.Point(295, 27);
            lblTenTB.Name = "lblTenTB";
            lblTenTB.Size = new System.Drawing.Size(102, 25);
            lblTenTB.TabIndex = 5;
            lblTenTB.Text = "Thiết bị 1";
            // 
            // lblSL
            // 
            lblSL.AutoSize = true;
            lblSL.Location = new System.Drawing.Point(160, 68);
            lblSL.Name = "lblSL";
            lblSL.Size = new System.Drawing.Size(112, 25);
            lblSL.TabIndex = 6;
            lblSL.Text = "Số Lượng:";
            // 
            // lblGiaTien
            // 
            lblGiaTien.AutoSize = true;
            lblGiaTien.ForeColor = System.Drawing.Color.Red;
            lblGiaTien.Location = new System.Drawing.Point(295, 111);
            lblGiaTien.Name = "lblGiaTien";
            lblGiaTien.Size = new System.Drawing.Size(108, 25);
            lblGiaTien.TabIndex = 7;
            lblGiaTien.Text = "00000000";
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Location = new System.Drawing.Point(160, 108);
            lblGia.Name = "lblGia";
            lblGia.Size = new System.Drawing.Size(52, 25);
            lblGia.TabIndex = 8;
            lblGia.Text = "Giá:";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new System.Drawing.Point(160, 27);
            lblTen.Name = "lblTen";
            lblTen.Size = new System.Drawing.Size(57, 25);
            lblTen.TabIndex = 9;
            lblTen.Text = "Tên:";
            // 
            // pbHinhAnh
            // 
            //pbHinhAnh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHinhAnh.BackgroundImage")));
            pbHinhAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pbHinhAnh.Location = new System.Drawing.Point(20, 19);
            pbHinhAnh.Name = "pbHinhAnh";
            pbHinhAnh.Size = new System.Drawing.Size(120, 118);
            pbHinhAnh.TabIndex = 4;
            pbHinhAnh.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pbHinhAnh);
            panel1.Controls.Add(txtSl);
            panel1.Controls.Add(lblTen);
            panel1.Controls.Add(btnBuy);
            panel1.Controls.Add(lblGia);
            panel1.Controls.Add(lblTenTB);
            panel1.Controls.Add(lblGiaTien);
            panel1.Controls.Add(lblSL);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(560, 170);
            panel1.TabIndex = 12;
        }
    }
}
