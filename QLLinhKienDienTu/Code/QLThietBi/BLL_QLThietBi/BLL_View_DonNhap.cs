using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLThietBi;
using DTO_QLThietBi;

namespace BLL_QLThietBi
{
    public class BLL_View_DonNhap
    {
        DAL_VIEW_Nhap dalDonNhap = new DAL_VIEW_Nhap();

        public BLL_View_DonNhap()
        {
        }
        public List<View_Nhap> loadViewDonNhap()
        {
            return dalDonNhap.loadViewDonNhap();
        }
    }
}
