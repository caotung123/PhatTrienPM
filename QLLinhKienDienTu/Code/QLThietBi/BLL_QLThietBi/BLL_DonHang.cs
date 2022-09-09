using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLThietBi;
using DTO_QLThietBi;
using System.Data;
using System.Windows.Forms;
using System.Data.Linq;
namespace BLL_QLThietBi
{
    public class BLL_DonHang
    {
        DAL_DonHang dalDonHang;

        public BLL_DonHang()
        {
            dalDonHang = new DAL_DonHang();
        }

        public List<DONHANG> loadDonHang()
        {
            return dalDonHang.loadDonHang();
        }
        public List<DONHANG> loadDonHangTheoGia(int pGiaDuoi, int pGiaTren)
        {
            return dalDonHang.loadDonHangTheoGia(pGiaDuoi, pGiaTren);
        }
        public List<DONHANG> loadDonHangTheoNgay(DateTime pNgayLap)
        {
            return dalDonHang.loadDonHangTheoNgay(pNgayLap);
        }
        public int themDonHang(DONHANG dh)
        {
            return dalDonHang.themDonHang(dh);
        }
        public int xoaDonHang(DONHANG pDonHang)
        {
            return dalDonHang.xoaDonHang(pDonHang);
        }
        public int suaDonHang(DONHANG dh)
        {
            return dalDonHang.suaDonHang(dh);
        }
        public int luuDonHang()
        {
            return dalDonHang.luuDonHang();
        }
        public DONHANG timDonHangTheoMa(int pMaDH)
        {
            return dalDonHang.timDonHangTheoMa(pMaDH);
        }
        public int thanhToanDonHang(DONHANG pDH)
        {
            return dalDonHang.thanhToanDonHang(pDH);
        }
    }
}
