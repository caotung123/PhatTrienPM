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
    public class DAL_LoaiThietBi
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        public DAL_LoaiThietBi()
        {

        }
        public List<LOAITB> loadLoaiThietBi()
        {
            return db_LinhKien.LOAITBs.Select(t => t).ToList();
        }
        public int themLoaiThietBi(LOAITB loai)
        {
            try
            {
                db_LinhKien.LOAITBs.InsertOnSubmit(loai);
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int xoaLoaiThietBi(LOAITB loai)
        {
            try
            {
                db_LinhKien.LOAITBs.DeleteOnSubmit(loai);
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int suaLoaiThietBi(LOAITB ploai)
        {
            try
            {
                LOAITB loai = db_LinhKien.LOAITBs.Where(t => t.MALOAI == ploai.MALOAI).FirstOrDefault();
                loai = ploai;
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int luuLoaiThietBi()
        {
            try
            {
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public LOAITB timLoaiThietBiTheoMa(int pMaLoai)
        {
            try
            {
                return db_LinhKien.LOAITBs.Select(t => t).Where(t => t.MALOAI == pMaLoai).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
