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
    public class BLL_DonNhap
    {
        DAL_DonNhap dalDonNhap;

        public BLL_DonNhap()
        {
            dalDonNhap = new DAL_DonNhap();
        }

        public List<DONNHAP> loadDonNhap()
        {
            return dalDonNhap.loadDonNhap();
        }
        public int themDonNhap(DONNHAP dn)
        {
            return dalDonNhap.themDonNhap(dn);
        }
        public int xoaDonNhap(DONNHAP pDonNhap)
        {
            return dalDonNhap.xoaDonNhap(pDonNhap);
        }
        public int suaDonNhap(DONNHAP dn)
        {
            return dalDonNhap.suaDonNhap(dn);
        }
        public int luuDonNhap()
        {
            return dalDonNhap.luuDonNhap();
        }
        public DONNHAP timDonNhapTheoMa(int pMaDN)
        {
            return dalDonNhap.timDonNhapTheoMa(pMaDN);
        }
        public int tinhTongThanhTien(int pMaDN)
        {
            return dalDonNhap.tinhTongThanhTien(pMaDN);
        }
    }
}
