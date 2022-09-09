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
    public class BLL_CoSo
    {
        DAL_CoSo dalCoSo;

        public BLL_CoSo()
        {
            dalCoSo = new DAL_CoSo();
        }

        public List<COSO> loadCoSo()
        {
            return dalCoSo.loadCoSo();
        }
        public int themCoSo(COSO cs)
        {
            return dalCoSo.themCoSo(cs);
        }
        public int xoaCoSo(COSO pCoSo)
        {
            return dalCoSo.xoaCoSo(pCoSo);
        }
        public int suaCoSo(COSO cs)
        {
            return dalCoSo.suaCoSo(cs);
        }
        public int luuCoSo()
        {
            return dalCoSo.luuCoSo();
        }
        public COSO timCoSoTheoMa(int pMaCS)
        {
            return dalCoSo.timCoSoTheoMa(pMaCS);
        }
    }
}
