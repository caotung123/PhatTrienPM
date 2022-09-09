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
    public class DAL_NhanVien
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        public DAL_NhanVien()
        {

        }
        public List<NHANVIEN> loadNhanVien()
        {
            return db_LinhKien.NHANVIENs.Select(t => t).ToList();
        }
        public int themNhanVien(NHANVIEN pNV)
        {
            try
            {
                db_LinhKien.NHANVIENs.InsertOnSubmit(pNV);
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int xoaNhanVien(NHANVIEN nv)
        {
            try
            {
                db_LinhKien.NHANVIENs.DeleteOnSubmit(nv);
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int suaNhanVien(NHANVIEN pNV)
        {
            try
            {
                NHANVIEN nv = db_LinhKien.NHANVIENs.Where(t => t.MANV == pNV.MANV).FirstOrDefault();
                nv = pNV;
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int luuNhanVien()
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
        public NHANVIEN timNhanVienTheoMa(int pMaNV)
        {
            try
            {
                return db_LinhKien.NHANVIENs.Select(t => t).Where(t => t.MANV == pMaNV).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
