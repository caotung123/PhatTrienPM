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
    public class DAL_CoSo
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        public DAL_CoSo()
        {

        }
        public List<COSO> loadCoSo()
        {
            return db_LinhKien.COSOs.Select(t => t).ToList();
        }
        public int themCoSo(COSO cs)
        {
            try
            {
                db_LinhKien.COSOs.InsertOnSubmit(cs);
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int xoaCoSo(COSO cs)
        {
            try
            {
                db_LinhKien.COSOs.DeleteOnSubmit(cs);
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int suaCoSo(COSO pCS)
        {
            try
            {
                COSO cs = db_LinhKien.COSOs.Where(t => t.MACS == pCS.MACS).FirstOrDefault();
                cs = pCS;
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int luuCoSo()
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
        public COSO timCoSoTheoMa(int pMaCS)
        {
            try
            {
                return db_LinhKien.COSOs.Select(t => t).Where(t => t.MACS == pMaCS).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
