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
    public class DAL_ThietBi
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        public DAL_ThietBi()
        {

        }
        public List<THIETBI> loadThietBi()
        {
            return db_LinhKien.THIETBIs.Select(t => t).ToList();
        }
        public List<THIETBI> loadThietBiTheoMaLoai(int pMaLoai)
        {
            try
            {
                return db_LinhKien.THIETBIs.Select(t => t).Where(t => t.MALOAI == pMaLoai).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public List<THIETBI> loadThietBiTheoTen(string pTen)
        {
            try
            {
                return db_LinhKien.THIETBIs.Select(t => t).Where(t => t.TENTB.Contains(pTen)).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public List<THIETBI> loadThietBiTheoGia(int pGiaDuoi, int pGiaTren)
        {
            try
            {
                return db_LinhKien.THIETBIs.Select(t => t).Where(t => t.GIA >= pGiaDuoi && t.GIA <= pGiaTren).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public int themThietBi(THIETBI tb)
        {
            try
            {
                db_LinhKien.THIETBIs.InsertOnSubmit(tb);
                db_LinhKien.SubmitChanges();
                db_LinhKien.Refresh(System.Data.Linq.RefreshMode.KeepChanges, tb);
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int xoaThietBi(THIETBI tb)
        {
            try
            {
                db_LinhKien.THIETBIs.DeleteOnSubmit(tb);
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int suaThietBi(THIETBI pTB)
        {
            try
            {
                THIETBI tb = db_LinhKien.THIETBIs.Where(t => t.MATB == pTB.MATB).FirstOrDefault();
                db_LinhKien.Refresh(System.Data.Linq.RefreshMode.KeepChanges, tb);
                tb = pTB;
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int luuThietBi()
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
        public THIETBI timThietBiTheoMa(int pMaTB)
        {
            try
            {
                return db_LinhKien.THIETBIs.Select(t => t).Where(t => t.MATB == pMaTB).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public List<THIETBI> loadSanPhamTheoTimKiem(string tensp)
        {
            return db_LinhKien.THIETBIs.Select(t => t).Where(t => t.TENTB.Contains(tensp)).ToList();
        }
    }
}
