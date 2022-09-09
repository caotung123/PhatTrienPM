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
using DTO_QLThietBi;


namespace QLThietBi.Presentation
{
    public partial class GUI_PhanQuyen : Form
    {
        BLL_NhanVien bllNhanVien = new BLL_NhanVien();
        BLL_DMMangHinh bllDMMangHinh = new BLL_DMMangHinh();

        public GUI_PhanQuyen()
        {
            InitializeComponent();
        }

        private void GUI_PhanQuyen_Load(object sender, EventArgs e)
        {
            loadCbbNhanVien();
            loadDgvMangHinhChon();
            loadDgvMangHinhKoChon();
        }

        void loadCbbNhanVien()
        {
            cbbNhanVien.DataSource = bllNhanVien.loadNhanVien();
            cbbNhanVien.DisplayMember = "TENNV";
            cbbNhanVien.ValueMember = "MANV";            
        }

        void loadDgvMangHinhChon()
        {
            string ma = cbbNhanVien.SelectedValue.ToString();
            int maNV = -1;
            try
            {
                maNV = int.Parse(cbbNhanVien.SelectedValue.ToString());
            }
            catch (Exception ex){}

            dtgMangHinhChon.DataSource = bllDMMangHinh.loadDMMangHinhTheoMaNV(maNV, true);
            dtgMangHinhChon.Columns[0].Visible = false;
            dtgMangHinhChon.Columns[2].Visible = false;
            dtgMangHinhChon.Columns[3].Visible = false;
            dtgMangHinhChon.Columns[4].Visible = false;
            dtgMangHinhChon.Columns[1].HeaderText = "Tên Màng Hình";
            dtgMangHinhChon.Columns[1].Width = 240;
        }

        void loadDgvMangHinhKoChon()
        {
            string ma = cbbNhanVien.SelectedValue.ToString();
            int maNV = -1;
            try
            {
               maNV = int.Parse(cbbNhanVien.SelectedValue.ToString());
            }catch(Exception ex){}
            
            dtgMangHinhKoChon.DataSource = bllDMMangHinh.loadDMMangHinhTheoMaNV(maNV,false);
            dtgMangHinhKoChon.Columns[0].Visible = false;
            dtgMangHinhKoChon.Columns[2].Visible = false;
            dtgMangHinhKoChon.Columns[3].Visible = false;
            dtgMangHinhKoChon.Columns[4].Visible = false;
            dtgMangHinhKoChon.Columns[1].HeaderText = "Tên Màng Hình";
            dtgMangHinhKoChon.Columns[1].Width = 240;
        }

        private void cbbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDgvMangHinhKoChon();
            loadDgvMangHinhChon();
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            int maNV = int.Parse(cbbNhanVien.SelectedValue.ToString());
            int maDM = int.Parse(dtgMangHinhChon.CurrentRow.Cells[0].Value.ToString());

            DMMANGHINH dm = bllDMMangHinh.timDMMangHinhTheoMa(maDM, maNV);
            if (dm != null)
            {
                int kq = bllDMMangHinh.suaDMMangHinhChon(dm, false);

                if(kq == 1)
                {
                    MessageBox.Show("Thành Công", "Thông báo");
                    loadDgvMangHinhChon();
                    loadDgvMangHinhKoChon();
                }               
            }
            else
                MessageBox.Show("Không tìm thấy mà hình: " + maDM , "Thông báo");
           
        }

        private void btnALLPhai_Click(object sender, EventArgs e)
        {
            int maNV = int.Parse(cbbNhanVien.SelectedValue.ToString());
            List<DMMANGHINH> dsManhHinhChon = bllDMMangHinh.loadDMMangHinhTheoMaNV(maNV, true);

            foreach (var item in dsManhHinhChon)
            {
                int maDM = item.MADM;
                DMMANGHINH dm = bllDMMangHinh.timDMMangHinhTheoMa(maDM, maNV);
                bllDMMangHinh.suaDMMangHinhChon(dm, false);
            }
            loadDgvMangHinhChon();
            loadDgvMangHinhKoChon();
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            int maNV = int.Parse(cbbNhanVien.SelectedValue.ToString());
            int maDM = int.Parse(dtgMangHinhKoChon.CurrentRow.Cells[0].Value.ToString());

            DMMANGHINH dm = bllDMMangHinh.timDMMangHinhTheoMa(maDM, maNV);
            if (dm != null)
            {
                int kq = bllDMMangHinh.suaDMMangHinhChon(dm, true);

                if (kq == 1)
                {
                    MessageBox.Show("Thành Công", "Thông báo");
                    loadDgvMangHinhChon();
                    loadDgvMangHinhKoChon();
                }                    
            }
            else
                MessageBox.Show("Không tìm thấy mà hình: " + maDM, "Thông báo");
        }

        private void btnALLTrai_Click(object sender, EventArgs e)
        {
            int maNV = int.Parse(cbbNhanVien.SelectedValue.ToString());
            List<DMMANGHINH> dsManhHinhKoChon = bllDMMangHinh.loadDMMangHinhTheoMaNV(maNV, false);

            foreach (var item in dsManhHinhKoChon)
            {
                int maDM = item.MADM;
                DMMANGHINH dm = bllDMMangHinh.timDMMangHinhTheoMa(maDM, maNV);
                bllDMMangHinh.suaDMMangHinhChon(dm, true);
            }
            loadDgvMangHinhChon();
            loadDgvMangHinhKoChon();
        }
        
    }
}
