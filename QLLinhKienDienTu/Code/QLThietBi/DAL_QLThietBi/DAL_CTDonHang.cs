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
    public class DAL_CTDonHang
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        public DAL_CTDonHang()
        {

        }
        public List<CTDONHANG> loadCTDonHang()
        {
            return db_LinhKien.CTDONHANGs.Select(t => t).ToList();
        }
        public List<CTDONHANG> loadCTDonHangTheoMa(int pMaDH)
        {
            try
            {
                return db_LinhKien.CTDONHANGs.Select(t => t).Where(t => t.MADH == pMaDH).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public int themCTDonHang(CTDONHANG ctdh)
        {
            try
            {
                db_LinhKien.CTDONHANGs.InsertOnSubmit(ctdh);

                //tru so luong
                THIETBI tb = db_LinhKien.THIETBIs.Where(t => t.MATB == ctdh.MATB).FirstOrDefault();                
                tb.SOLUONG -= ctdh.SOLUONG;                

                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int xoaCTDonHang(CTDONHANG ctdh)
        {
            try
            {
                db_LinhKien.CTDONHANGs.DeleteOnSubmit(ctdh);

                //cong lai sl
                THIETBI tb = db_LinhKien.THIETBIs.Where(t => t.MATB == ctdh.MATB).FirstOrDefault();                
                tb.SOLUONG += ctdh.SOLUONG;
                new DAL_ThietBi().suaThietBi(tb);

                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int suaCTDonHang(CTDONHANG pCTDH)
        {
            try
            {                
                CTDONHANG ctdh = db_LinhKien.CTDONHANGs.Where(t => t.MADH == pCTDH.MADH && t.MATB == pCTDH.MATB).FirstOrDefault();                                                
                db_LinhKien.Refresh(System.Data.Linq.RefreshMode.KeepChanges, ctdh);
                ctdh = pCTDH;

                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int luuCTDonHang()
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
        //public int tinhTongCTDonHang(int pMaDH)
        //{
        //    try
        //    {
        //        int tong = int.Parse( db_LinhKien.CTDONHANGs.Select(t => t).Where(t => t.MADH == pMaDH).Sum(t => t.THANHTIEN).Value.ToString());
        //        return tong;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return 0;
        //    }
        //}
        public CTDONHANG timCTDonHangTheoMaSP(int pMaDH, int pMaTB)
        {
            try
            {
                return db_LinhKien.CTDONHANGs.Select(t => t).Where(t => t.MADH == pMaDH && t.MATB == pMaTB).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
