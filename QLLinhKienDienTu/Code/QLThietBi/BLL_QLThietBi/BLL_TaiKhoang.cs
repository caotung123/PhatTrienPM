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
    public class BLL_TaiKhoang
    {
        DAL_TaiKhoang dalTaiKhoang;

        public BLL_TaiKhoang()
        {
            dalTaiKhoang = new DAL_TaiKhoang();
        }

        public List<TAIKHOANG> loadTaiKhoang()
        {
            return dalTaiKhoang.loadTaiKhoang();
        }
        public int themTaiKhoang(TAIKHOANG tk)
        {
            return dalTaiKhoang.themTaiKhoang(tk);
        }
        public int xoaTaiKhoang(TAIKHOANG tk)
        {
            return dalTaiKhoang.xoaTaiKhoang(tk);
        }
        public int suaTaiKhoang(TAIKHOANG tk)
        {
            return dalTaiKhoang.suaTaiKhoang(tk);
        }
        public int luuTaiKhoang()
        {
            return dalTaiKhoang.luuTaiKhoang();
        }
        public TAIKHOANG timTaiKhoangTheoMa(string pTenTK)
        {
            return dalTaiKhoang.timTaiKhoangTheoMa(pTenTK);
        }
        public TAIKHOANG dangNhap(string pTenTK, string pMatKhau)
        {
            return dalTaiKhoang.dangNhap(pTenTK, pMatKhau);
        }
        public TAIKHOANG timTaiKhoangTheoMaNV(int pMaNV)
        {
            return dalTaiKhoang.timTaiKhoangTheoMaNV(pMaNV);
        }
    }
}
