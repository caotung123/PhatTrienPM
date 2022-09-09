using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_QLThietBi;

namespace QLThietBi.Presentation
{
    public partial class GUI_BAOCAO : Form
    {
        BLL_BaoCao bllbaocao = new BLL_BaoCao();
        public GUI_BAOCAO()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (radNgay.Checked)
            {
                //DateTime d = new DateTime(2021, 02, 22); //dtNgay.Value.Date;
                DateTime d = dtNgay.Value.Date;
                dataGridView1.DataSource = bllbaocao.timKiemNgay(d);
                if (dataGridView1.Rows.Count > 0)
                {

                    tinh_tong(dataGridView1.Rows.Count);
                }
                else
                {
                    MessageBox.Show("Không có hóa đơn nào được lập trong trong ngày [" + string.Format("{0:dd/MM/yyyy}", d) + "] !",
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblTongDoanhThu.Text = "";
                }
            }
            else if (radThang.Checked)
            {
                int thang = int.Parse(cboThang.SelectedItem.ToString());
                dataGridView1.DataSource = bllbaocao.timKiemThang(thang);
                if (dataGridView1.Rows.Count > 0)
                {

                    tinh_tong(dataGridView1.Rows.Count);
                }
                else
                {
                    MessageBox.Show("Không có hóa đơn nào được lập trong trong Tháng [" + thang + "] !",
                             "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblTongDoanhThu.Text = "";
                }

            }
            else if (radQuy.Checked)
            {
                if (cboQuy.SelectedItem.ToString().Equals("Quý 1"))
                {
                    dataGridView1.DataSource = bllbaocao.timKiemQuy1();
                    if (dataGridView1.Rows.Count > 0) //nếu có 1 hàng thì xuât ra
                    {

                        tinh_tong(dataGridView1.Rows.Count);
                    }
                    else
                    {
                        MessageBox.Show("Không có hóa đơn nào được lập trong trong Quý 1 !",
                                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblTongDoanhThu.Text = "";
                    }
                }
                else
                {
                    dataGridView1.DataSource = bllbaocao.timKiemQuy2();
                    if (dataGridView1.Rows.Count > 0)
                    {

                        tinh_tong(dataGridView1.Rows.Count);
                    }
                    else
                    {
                        MessageBox.Show("Không có hóa đơn nào được lập trong trong Quý 2 !",
                                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblTongDoanhThu.Text = "";
                    }
                }
            }
        }

        private void GUI_BAOCAO_Load(object sender, EventArgs e)
        {

        }
        private void tinh_tong(int sodong)
        {
            decimal tong = 0;
            for (int i = 0; i < sodong; i++)
            {
                try
                {
                    var value = (decimal)dataGridView1.Rows[i].Cells[5].Value;
                    tong += value;
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            lblTongDoanhThu.Text = string.Format("{0:0,0}", tong);

        }
    }
}
