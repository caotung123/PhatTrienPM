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
    public class BLL_ThietBi
    {
        DAL_ThietBi dalThietBi;

        public BLL_ThietBi()
        {
            dalThietBi = new DAL_ThietBi();
        }

        public List<THIETBI> loadThietBi()
        {
            return dalThietBi.loadThietBi();
        }
        public List<THIETBI> loadThietBiTheoMaLoai(int pMaLoai)
        {
            return dalThietBi.loadThietBiTheoMaLoai(pMaLoai);
        }
        public List<THIETBI> loadThietBiTheoTen(string pTen)
        {
            return dalThietBi.loadThietBiTheoTen(pTen);
        }
        public List<THIETBI> loadThietBiTheoGia(int pGiaDuoi, int pGiaTren)
        {
            return dalThietBi.loadThietBiTheoGia(pGiaDuoi, pGiaTren);
        }
        public int themThietBi(THIETBI tb)
        {
            return dalThietBi.themThietBi(tb);
        }
        public int xoaThietBi(THIETBI pThietBi)
        {
            return dalThietBi.xoaThietBi(pThietBi);
        }
        public int suaThietBi(THIETBI tb)
        {
            return dalThietBi.suaThietBi(tb);
        }
        public int luuThietBi()
        {
            return dalThietBi.luuThietBi();
        }
        public THIETBI timThietBiTheoMa(int pMatb)
        {
            return dalThietBi.timThietBiTheoMa(pMatb);
        }
        public List<THIETBI> loadSanPhamTheoTimKiem(string tensp)
        {
            return dalThietBi.loadSanPhamTheoTimKiem(tensp);
        }
    }
}
