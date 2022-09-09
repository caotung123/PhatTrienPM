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
    public class DAL_DonHang
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        public DAL_DonHang()
        {            
        }
        public List<DONHANG> loadDonHang()
        {
            return db_LinhKien.DONHANGs.Select(t => t).ToList();
        }
        public List<DONHANG> loadDonHangTheoGia(int pGiaDuoi, int pGiaTren)
        {
            try
            {
                return db_LinhKien.DONHANGs.Select(t => t).Where(t => t.TONGTIEN >= pGiaDuoi && t.TONGTIEN <= pGiaTren).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public List<DONHANG> loadDonHangTheoNgay(DateTime pNgayLap)
        {
            try
            {
                return db_LinhKien.DONHANGs.Select(t => t).Where(t => t.NGAYLAP == pNgayLap).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public int themDonHang(DONHANG dh)
        {
            try
            {
                db_LinhKien.DONHANGs.InsertOnSubmit(dh);
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int xoaDonHang(DONHANG dh)
        {
            try
            {
                db_LinhKien.Refresh(System.Data.Linq.RefreshMode.KeepChanges, dh);
                db_LinhKien.DONHANGs.DeleteOnSubmit(dh);
                luuDonHang();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int suaDonHang(DONHANG pDH)
        {
            try
            {
                DONHANG dh = db_LinhKien.DONHANGs.Where(t => t.MADH == pDH.MADH).FirstOrDefault();
                dh = pDH;
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int luuDonHang()
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
        public DONHANG timDonHangTheoMa(int pMaDH)
        {
            try
            {
                return db_LinhKien.DONHANGs.Select(t => t).Where(t => t.MADH == pMaDH).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public int thanhToanDonHang(DONHANG pDH)
        {
            try
            {
                
                DONHANG dh = new DONHANG();
                dh = db_LinhKien.DONHANGs.Where(t => t.MADH == pDH.MADH).FirstOrDefault();
                //dh = pDH;
                db_LinhKien.Refresh(System.Data.Linq.RefreshMode.KeepChanges, dh);
                pDH.TINHTRANG = "HOÀN THÀNH";
                dh = pDH;                
                luuDonHang();                
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
