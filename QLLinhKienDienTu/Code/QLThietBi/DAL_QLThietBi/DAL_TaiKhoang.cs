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
    public class DAL_TaiKhoang
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        public DAL_TaiKhoang()
        {

        }
        public List<TAIKHOANG> loadTaiKhoang()
        {
            return db_LinhKien.TAIKHOANGs.Select(t => t).ToList();
        }
        public int themTaiKhoang(TAIKHOANG tk)
        {
            try
            {
                db_LinhKien.TAIKHOANGs.InsertOnSubmit(tk);               
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int xoaTaiKhoang(TAIKHOANG tk)
        {
            try
            {
                db_LinhKien.TAIKHOANGs.DeleteOnSubmit(tk);
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int suaTaiKhoang(TAIKHOANG pTK)
        {
            try
            {
                TAIKHOANG tk = db_LinhKien.TAIKHOANGs.Where(t => t.MATKHAU == pTK.MATKHAU).FirstOrDefault();
                tk = pTK;
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int luuTaiKhoang()
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
        public TAIKHOANG timTaiKhoangTheoMa(string pTenTK)
        {
            try
            {
                return db_LinhKien.TAIKHOANGs.Select(t => t).Where(t => t.TENTK == pTenTK).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
        public TAIKHOANG timTaiKhoangTheoMaNV(int pMaNV)
        {
            try
            {
                return db_LinhKien.TAIKHOANGs.Select(t => t).Where(t => t.MANV == pMaNV).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public TAIKHOANG dangNhap(string pTenTK, string pMatKhau)
        {
            try
            {
                return db_LinhKien.TAIKHOANGs.Select(t => t).Where(t => t.TENTK == pTenTK && t.MATKHAU == pMatKhau).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
