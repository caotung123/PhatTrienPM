using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLThietBi;
using DTO_QLThietBi;

namespace BLL_QLThietBi
{
    public class BLL_VIEW_GioHang
    {
        DAL_VIEW_GioHang  dalVIEWGioHang = new DAL_VIEW_GioHang();
        public BLL_VIEW_GioHang()
       {

       }
        public List<VIEW_GIOHANG> loadVIEWGioHangMaDH(int pMaDH)
        {
            return dalVIEWGioHang.loadVIEWGioHangMaDH(pMaDH);
        }
        public List<VIEW_GIOHANG> loadVIEWGioHang()
        {
            return dalVIEWGioHang.loadVIEWGioHang();
        }
        public VIEW_GIOHANG timVIEWGioHangTheoMaTB(int pMaTB)
        {
            return dalVIEWGioHang.timVIEWGioHangTheoMaTB(pMaTB);
        }
    }
}
