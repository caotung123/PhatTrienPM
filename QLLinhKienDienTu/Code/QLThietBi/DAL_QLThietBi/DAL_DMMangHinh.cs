using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLThietBi;
using System.Data;
using System.Windows.Forms;
using System.Data.Linq;

namespace DAL_QLThietBi
{
    public class DAL_DMMangHinh
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        public DAL_DMMangHinh()
        {

        }
        public List<DMMANGHINH> loadDMMangHinh()
        {
            return db_LinhKien.DMMANGHINHs.Select(t => t).ToList();
        }
        public int themDMMangHinh(DMMANGHINH dm)
        {
            try
            {
                db_LinhKien.DMMANGHINHs.InsertOnSubmit(dm);
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int xoaDMMangHinh(DMMANGHINH dm)
        {
            try
            {
                db_LinhKien.DMMANGHINHs.DeleteOnSubmit(dm);
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int suaDMMangHinh(DMMANGHINH pdm)
        {
            try
            {
                DMMANGHINH dm = db_LinhKien.DMMANGHINHs.Where(t => t.MADM == pdm.MADM).FirstOrDefault();
                dm = pdm;
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int luuDMMangHinh()
        {
            try
            {
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
       
        public List<DMMANGHINH> loadDMMangHinhTheoMaNV(int pMaNV)
        {
            try
            {
                return db_LinhKien.DMMANGHINHs.Select(t => t).Where(t => t.MANV == pMaNV).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public List<DMMANGHINH> loadDMMangHinhTheoMaNV(int pMaNV, bool pChon)
        {
            try
            {
                return db_LinhKien.DMMANGHINHs.Select(t => t).Where(t => t.MANV == pMaNV && t.CHON == pChon).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public int suaDMMangHinhChon(DMMANGHINH pDMMangHinh, bool pChon)
        {
            try
            {
                DMMANGHINH dmUP =  db_LinhKien.DMMANGHINHs.Select(t => t).Where(t => t.MANV == pDMMangHinh.MANV && t.MADM == pDMMangHinh.MADM).FirstOrDefault();
                dmUP.CHON = pChon;
                luuDMMangHinh();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public DMMANGHINH timDMMangHinhTheoMa(int pMaDM, int pMaNV)
        {
            try
            {
                return db_LinhKien.DMMANGHINHs.Select(t => t).Where(t => t.MADM == pMaDM && t.MANV == pMaNV).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
