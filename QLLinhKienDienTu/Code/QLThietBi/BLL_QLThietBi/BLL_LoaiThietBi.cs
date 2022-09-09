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
    public class BLL_LoaiThietBi
    {
        DAL_LoaiThietBi dalLoaiThietBi;

        public BLL_LoaiThietBi()
        {
            dalLoaiThietBi = new DAL_LoaiThietBi();
        }

        public List<LOAITB> loadLoaiThietBi()
        {
            return dalLoaiThietBi.loadLoaiThietBi();
        }
        public int themLoaiThietBi(LOAITB pLoai)
        {
            return dalLoaiThietBi.themLoaiThietBi(pLoai);
        }
        public int xoaLoaiThietBi(LOAITB pLoai)
        {
            return dalLoaiThietBi.xoaLoaiThietBi(pLoai);
        }
        public int suaLoaiThietBi(LOAITB loai)
        {
            return dalLoaiThietBi.suaLoaiThietBi(loai);
        }
        public int luuLoaiThietBi()
        {
            return dalLoaiThietBi.luuLoaiThietBi();
        }
        public LOAITB timLoaiThietBiTheoMa(int pMaLoai)
        {
            return dalLoaiThietBi.timLoaiThietBiTheoMa(pMaLoai);
        }
    }
}
