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
    public class BLL_NhaCungCap
    {
        DAL_NhaCungCap dalNhaCungCap;

        public BLL_NhaCungCap()
        {
            dalNhaCungCap = new DAL_NhaCungCap();
        }

        public List<NHACC> loadNhaCungCap()
        {
            return dalNhaCungCap.loadNhaCungCap();
        }
        public int themNhaCungCap(NHACC pNhaCC)
        {
            return dalNhaCungCap.themNhaCungCap(pNhaCC);
        }
        public int xoaNhaCungCap(NHACC pNhaCC)
        {
            return dalNhaCungCap.xoaNhaCungCap(pNhaCC);
        }
        public int suaNhaCungCap(NHACC ncc)
        {
            return dalNhaCungCap.suaNhaCungCap(ncc);
        }
        public int luuNhaCungCap()
        {
            return dalNhaCungCap.luuNhaCungCap();
        }
        public NHACC timNhaCungCapTheoMa(int pMaNCC)
        {
            return dalNhaCungCap.timNhaCungCapTheoMa(pMaNCC);
        }
    }
}
