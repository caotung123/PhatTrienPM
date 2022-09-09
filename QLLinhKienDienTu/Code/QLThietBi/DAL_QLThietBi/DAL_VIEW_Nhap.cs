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
    public class DAL_VIEW_Nhap
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();

        public DAL_VIEW_Nhap()
        {
        }

        public List<View_Nhap> loadViewDonNhap()
        {            
            return db_LinhKien.View_Nhaps.Select(t => t).ToList();            
        }
    }
}
