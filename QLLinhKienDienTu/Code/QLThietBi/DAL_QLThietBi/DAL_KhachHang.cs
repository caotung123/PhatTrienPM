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
    public class DAL_KhachHang
    {
        QL_LinhKienDataContext db_LinhKien = new QL_LinhKienDataContext();
        public DAL_KhachHang()
        {

        }
        public List<KHACHHANG> loadKhachHang()
        {
            return db_LinhKien.KHACHHANGs.Select(t => t).ToList();
        }
        public int themKhachHang(KHACHHANG kh)
        {
            try
            {
                db_LinhKien.KHACHHANGs.InsertOnSubmit(kh);
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int xoaKhachHang(KHACHHANG kh)
        {
            try
            {
                db_LinhKien.KHACHHANGs.DeleteOnSubmit(kh);
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int suaKhachHang(KHACHHANG pKH)
        {
            try
            {
                KHACHHANG kh = db_LinhKien.KHACHHANGs.Where(t => t.MAKH == pKH.MAKH).FirstOrDefault();
                kh = pKH;
                db_LinhKien.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int luuKhachHang()
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
        public KHACHHANG timKhachHangTheoMa(int pMaKH)
        {
            try
            {
                return db_LinhKien.KHACHHANGs.Select(t => t).Where(t => t.MAKH == pMaKH).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
