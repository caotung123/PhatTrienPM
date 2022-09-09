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
    public class BLL_BaoCao
    {
        DAL_BaoCao dalBaocao = new DAL_BaoCao();

        public List<show_DBResult> timKiemNgay(DateTime ngay)
        {
            return dalBaocao.timKiemNgay(ngay);
        }
        public List<show_DB_ThangResult> timKiemThang(int thang)
        {
            return dalBaocao.timKiemThang(thang);
        }
        public List<show_DB_Quy_1Result> timKiemQuy1()
        {
            return dalBaocao.timKiemQuy1();
        }
        public List<show_DB_Quy_2Result> timKiemQuy2()
        {
            return dalBaocao.timKiemQuy2();
        }
    }
}
