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
    public partial class GUI_NhaCungCap : Form
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        BLL_NhaCungCap bllNhaCC = new BLL_NhaCungCap();

        public GUI_NhaCungCap()
        {
            InitializeComponent();
        }

        private void GUI_NhaCungCap_Load(object sender, EventArgs e)
        {
            loadDgvNhaCC();
        }

        void loadDgvNhaCC()
        {
            dgvNhaCC.DataSource = bllNhaCC.loadNhaCungCap();
            dgvNhaCC.Columns[0].Visible = false;
            dgvNhaCC.Columns[1].Width = 200;
            dgvNhaCC.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvNhaCC.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;   
            dgvNhaCC.Columns[2].Width = 150;
            dgvNhaCC.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvNhaCC.Columns[3].Width = 250;
            dgvNhaCC.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NHACC nhaCC = new NHACC();
            nhaCC.TENNCC = txtTen.Text;
            nhaCC.SDT = txtSDT.Text;
            nhaCC.DIACHI = txtDiaChi.Text;

            int kq = bllNhaCC.themNhaCungCap(nhaCC);
            if (kq == 1)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDgvNhaCC();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhaCC.SelectedRows.Count < 1)
                return;

            int maNCC = int.Parse(dgvNhaCC.CurrentRow.Cells[0].Value.ToString());
            NHACC nhaCC = bllNhaCC.timNhaCungCapTheoMa(maNCC);
            if (nhaCC == null)
            {
                MessageBox.Show("Không tìm thấy cơ sở có mã:" + maNCC, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                int kq = bllNhaCC.xoaNhaCungCap(nhaCC);
                if (kq == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDgvNhaCC();
                    clear();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhaCC.SelectedRows.Count < 1)
                return;

            int ma = int.Parse(dgvNhaCC.CurrentRow.Cells[0].Value.ToString());

            NHACC nhaCC = bllNhaCC.timNhaCungCapTheoMa(ma);
            nhaCC.TENNCC = txtTen.Text;
            nhaCC.SDT = txtSDT.Text;
            nhaCC.DIACHI = txtDiaChi.Text;

            int kq = bllNhaCC.suaNhaCungCap(nhaCC);
            if (kq == 1)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDgvNhaCC();
            }
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTen.Text = dgvNhaCC.CurrentRow.Cells[1].Value.ToString();
            txtSDT.Text = dgvNhaCC.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNhaCC.CurrentRow.Cells[3].Value.ToString();
        }

        void clear()
        {
            txtTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }


    }
}
