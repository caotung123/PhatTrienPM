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
    public class DAL_CTDonNhap
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        public DAL_CTDonNhap()
        {

        }
        public List<CTDONHAP> loadCTDonNhap()
        {
            return db_LinhKien.CTDONHAPs.Select(t => t).ToList();
        }
        public List<CTDONHAP> loadCTDonNhapTheMaDN(int pMaDN)
        {
            return db_LinhKien.CTDONHAPs.Select(t => t).Where(t => t.MADN == pMaDN).ToList();
        }
        public int themCTDonNhap(CTDONHAP ctdn)
        {
            try
            {                
                db_LinhKien.CTDONHAPs.InsertOnSubmit(ctdn);  
              
                //cong sl linh kien
                THIETBI tb = db_LinhKien.THIETBIs.Where(t => t.MATB == ctdn.MATB).FirstOrDefault();
                tb.SOLUONG += ctdn.SOLUONG;
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
        public int xoaCTDonNhap(CTDONHAP ctdn)
        {
            try
            {
                db_LinhKien.CTDONHAPs.DeleteOnSubmit(ctdn);

                // tru sl linh kien 
                THIETBI tb = db_LinhKien.THIETBIs.Where(t => t.MATB == ctdn.MATB).FirstOrDefault();
                tb.SOLUONG -= ctdn.SOLUONG ;
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
        public int suaCTDonNhap(CTDONHAP pCTDN)
        {
            try
            {

                CTDONHAP ctdn = db_LinhKien.CTDONHAPs.Where(t => t.MADN == pCTDN.MADN && t.MATB == pCTDN.MATB).FirstOrDefault();                
                db_LinhKien.Refresh(System.Data.Linq.RefreshMode.KeepChanges, ctdn);
                ctdn = pCTDN;

                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int luuCTDonNhap()
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
        public CTDONHAP timCTDonNhapTheoMaDNMaTB(int pMaDN, int pMaTB)
        {
            try
            {
                return db_LinhKien.CTDONHAPs.Select(t => t).Where(t => t.MADN == pMaDN && t.MATB == pMaTB).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
