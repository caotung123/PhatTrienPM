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
    public class DAL_VIEW_GioHang
    {
         QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();

         public DAL_VIEW_GioHang()
        {

        }
         public List<VIEW_GIOHANG> loadVIEWGioHangMaDH(int pMaDH)
        {
            return db_LinhKien.VIEW_GIOHANGs.Where(t => t.MADH == pMaDH).ToList();
        }
         public List<VIEW_GIOHANG> loadVIEWGioHang()
        {
            return db_LinhKien.VIEW_GIOHANGs.Select(t => t).ToList();
        }
        public VIEW_GIOHANG timVIEWGioHangTheoMaTB(int pMaTB)
         {
             return db_LinhKien.VIEW_GIOHANGs.Where(t => t.MATB == pMaTB).FirstOrDefault();
         }
    }
}
