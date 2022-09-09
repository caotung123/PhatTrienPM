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
    public class BLL_NhanVien
    {
        DAL_NhanVien dalNhanVien;

        public BLL_NhanVien()
        {
            dalNhanVien = new DAL_NhanVien();
        }

        public List<NHANVIEN> loadNhanVien()
        {
            return dalNhanVien.loadNhanVien();
        }
        public int themNhanVien(NHANVIEN pNhanVien)
        {
            return dalNhanVien.themNhanVien(pNhanVien);
        }
        public int xoaNhanVien(NHANVIEN pNhanVien)
        {
            return dalNhanVien.xoaNhanVien(pNhanVien);
        }
        public int suaNhanVien(NHANVIEN pNhanVien)
        {
            return dalNhanVien.suaNhanVien(pNhanVien);
        }
        public int luuNhanVien()
        {
            return dalNhanVien.luuNhanVien();
        }
        public NHANVIEN timNhanVienTheoMa(int pMaNV)
        {
            return dalNhanVien.timNhanVienTheoMa(pMaNV);
        }
    }
}
