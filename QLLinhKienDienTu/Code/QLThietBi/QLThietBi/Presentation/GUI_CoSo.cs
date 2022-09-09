using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLThietBi;
using BLL_QLThietBi;

namespace QLThietBi.Presentation
{
    public partial class GUI_CoSo : Form
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        BLL_CoSo bllCoSo = new BLL_CoSo();
        public GUI_CoSo()
        {
            InitializeComponent();
        }

        private void GUI_CoSo_Load(object sender, EventArgs e)
        {            
            loadCoSo();
        }
        void loadCoSo()
        {
            dtgCoSo.DataSource = bllCoSo.loadCoSo();
            chinhSuaDtgCoSo();
        }
        void chinhSuaDtgCoSo()
        {
            dtgCoSo.Columns[0].Width = 60;
            dtgCoSo.Columns[1].Width = 200;
            dtgCoSo.Columns[2].Width = 120;
            dtgCoSo.Columns[3].Width = 500;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
                return;

            int maCS = int.Parse(txtMa.Text);

            COSO cs = bllCoSo.timCoSoTheoMa(maCS);
            cs.TENCS = txtTen.Text;
            cs.SDT = txtSDT.Text;
            cs.DIACHI = txtDiaChi.Text;
            int kq = bllCoSo.suaCoSo(cs);
            if (kq == 1)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadCoSo();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int macs = int.Parse(txtMa.Text);
            COSO cs = bllCoSo.timCoSoTheoMa(macs);
            if (cs == null)
            {
                MessageBox.Show("Không tìm thấy cơ sở có mã:" + macs, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                int kq = bllCoSo.xoaCoSo(cs);
                if (kq == 1)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadCoSo();
                    clear();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            COSO cs = new COSO();
            cs.TENCS = txtTen.Text;
            cs.SDT = txtSDT.Text;
            cs.DIACHI = this.txtDiaChi.Text;

            int kq = bllCoSo.themCoSo(cs);
            if (kq == 1)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadCoSo();
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void dtgCoSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dtgCoSo.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dtgCoSo.CurrentRow.Cells[1].Value.ToString();
            txtSDT.Text = dtgCoSo.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dtgCoSo.CurrentRow.Cells[3].Value.ToString();
        }

        void clear()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }
        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}
