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
    public class DAL_VIEW_CTDonNhap
    {
        
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();

        public DAL_VIEW_CTDonNhap()
        {

        }
        public List<View_CTNhap> loadCTDonNhapMa(int pMa)
        {
            return db_LinhKien.View_CTNhaps.Where(t => t.MADN == pMa).ToList();
        }
        public List<View_CTNhap> loadCTDonNhap()
        {
            return db_LinhKien.View_CTNhaps.Select(t => t).ToList();
        }
    }
}
