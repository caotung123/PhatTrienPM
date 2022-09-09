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
    public class DAL_BaoCao
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        public DAL_BaoCao()
        {

        }
        public List<show_DBResult> timKiemNgay(DateTime ngay)
        {
            try
            {
                var data = db_LinhKien.show_DB(ngay).ToList();
                return data;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public List<show_DB_ThangResult> timKiemThang(int thang)
        {
            try
            {
                var data = db_LinhKien.show_DB_Thang(thang).ToList();
                return data;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public List<show_DB_Quy_1Result> timKiemQuy1()
        {
            try
            {
                var data = db_LinhKien.show_DB_Quy_1().ToList();
                return data;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public List<show_DB_Quy_2Result> timKiemQuy2()
        {
            try
            {
                var data = db_LinhKien.show_DB_Quy_2().ToList();
                return data;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }

}
