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
    public partial class GUI_Loai : Form
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        BLL_LoaiThietBi bllLoai = new BLL_LoaiThietBi();
        public GUI_Loai()
        {
            InitializeComponent();
        }

        private void GUI_Loai_Load(object sender, EventArgs e)
        {
            loadLoai();
        }

        void loadLoai()
        {
            dtgLoai.DataSource = bllLoai.loadLoaiThietBi();
            chinhSuaDtgLoai();
        }

        void chinhSuaDtgLoai()
        {
            dtgLoai.Columns[0].Width = 60;
            dtgLoai.Columns[1].Width = 200;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LOAITB loai = new LOAITB();
            loai.TENLOAI = txtTen.Text;

            int kq = bllLoai.themLoaiThietBi(loai);
            if (kq == 1)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadLoai();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maLoai = int.Parse(txtMa.Text);
            LOAITB loai = bllLoai.timLoaiThietBiTheoMa(maLoai);
            if (loai == null)
            {
                MessageBox.Show("Không tìm thấy cơ sở có mã:" + maLoai, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                int kq = bllLoai.xoaLoaiThietBi(loai);
                if (kq == 1)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadLoai();
                    clear();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
                return;

            int maLoai = int.Parse(txtMa.Text);

            LOAITB loai = bllLoai.timLoaiThietBiTheoMa(maLoai);
            loai.TENLOAI = txtTen.Text;
            int kq = bllLoai.themLoaiThietBi(loai);
            if (kq == 1)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadLoai();
            }
        }
        void clear()
        {
            txtMa.Clear();
            txtTen.Clear();
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void dtgLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dtgLoai.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dtgLoai.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
