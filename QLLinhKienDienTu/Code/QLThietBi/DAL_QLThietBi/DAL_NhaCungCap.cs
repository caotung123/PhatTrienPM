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
    public class DAL_NhaCungCap
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        public DAL_NhaCungCap()
        {

        }
        public List<NHACC> loadNhaCungCap()
        {
            return db_LinhKien.NHACCs.Select(t => t).ToList();
        }
        public int themNhaCungCap(NHACC ncc)
        {
            try
            {
                db_LinhKien.NHACCs.InsertOnSubmit(ncc);
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int xoaNhaCungCap(NHACC ncc)
        {
            try
            {
                db_LinhKien.NHACCs.DeleteOnSubmit(ncc);
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int suaNhaCungCap(NHACC pNCC)
        {
            try
            {
                NHACC ncc = db_LinhKien.NHACCs.Where(t => t.MANCC == pNCC.MANCC).FirstOrDefault();
                ncc = pNCC;
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int luuNhaCungCap()
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
        public NHACC timNhaCungCapTheoMa(int pMaNCC)
        {
            try
            {
                return db_LinhKien.NHACCs.Select(t => t).Where(t => t.MANCC == pMaNCC).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
