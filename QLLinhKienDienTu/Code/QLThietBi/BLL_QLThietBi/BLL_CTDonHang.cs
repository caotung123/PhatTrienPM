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
    public class BLL_CTDonHang
    {
        DAL_CTDonHang dalCTDonHang;

        public BLL_CTDonHang()
        {
            dalCTDonHang = new DAL_CTDonHang();
        }

        public List<CTDONHANG> loadCTDonHang()
        {
            return dalCTDonHang.loadCTDonHang();
        }
        public List<CTDONHANG> loadCTDonHangTheoMa(int pMaDH)
        {
            return dalCTDonHang.loadCTDonHangTheoMa(pMaDH);
        }
        public int themCTDonHang(CTDONHANG ctdh)
        {
            return dalCTDonHang.themCTDonHang(ctdh);
        }
        public int xoaCTDonHang(CTDONHANG pCTDonHang)
        {
            return dalCTDonHang.xoaCTDonHang(pCTDonHang);
        }
        public int suaCTDonHang(CTDONHANG ctdh)
        {
            return dalCTDonHang.suaCTDonHang(ctdh);
        }
        public int luuCTDonHang()
        {
            return dalCTDonHang.luuCTDonHang();
        }
        //public int tinhTongCTDonHang(int pMaDH)
        //{
        //    return dalCTDonHang.tinhTongCTDonHang(pMaDH);
        //}
        public CTDONHANG timCTDonHangTheoMaSP(int pMaDH, int pMaTB)
        {
            return dalCTDonHang.timCTDonHangTheoMaSP(pMaDH, pMaTB);
        }
    }
}
