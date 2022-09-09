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
    public class BLL_KhachHang
    {
        DAL_KhachHang dalKhachHang;

        public BLL_KhachHang()
        {
            dalKhachHang = new DAL_KhachHang();
        }

        public List<KHACHHANG> loadKhachHang()
        {
            return dalKhachHang.loadKhachHang();
        }
        public int themKhachHang(KHACHHANG kh)
        {
            return dalKhachHang.themKhachHang(kh);
        }
        public int xoaKhachHang(KHACHHANG pKhachHang)
        {
            return dalKhachHang.xoaKhachHang(pKhachHang);
        }
        public int suaKhachHang(KHACHHANG kh)
        {
            return dalKhachHang.suaKhachHang(kh);
        }
        public int luuKhachHang()
        {
            return dalKhachHang.luuKhachHang();
        }
        public KHACHHANG timKhachHangTheoMa(int pMaKH)
        {
            return dalKhachHang.timKhachHangTheoMa(pMaKH);
        }
    }
}
