using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLThietBi;
using DTO_QLThietBi;

namespace BLL_QLThietBi
{
    public class BLL_View_CTNhap
    {        
       DAL_VIEW_CTDonNhap  dalVIEWCTDonNhap = new DAL_VIEW_CTDonNhap();
        public BLL_View_CTNhap()
       {

       }
        public List<View_CTNhap> loadCTDonNhapMa(int map)
        {
            return dalVIEWCTDonNhap.loadCTDonNhapMa(map);
        }
        public List<View_CTNhap> loadCTDonNhap()
        {
            return dalVIEWCTDonNhap.loadCTDonNhap();
        }
    }
}
