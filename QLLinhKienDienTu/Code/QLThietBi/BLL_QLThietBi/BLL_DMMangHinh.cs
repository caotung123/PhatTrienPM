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
    public class BLL_DMMangHinh
    {
         DAL_DMMangHinh dalDMMangHinh;

        public BLL_DMMangHinh()
        {
            dalDMMangHinh = new DAL_DMMangHinh();
        }

        public List<DMMANGHINH> loadDMMangHinh()
        {
            return dalDMMangHinh.loadDMMangHinh();
        }
        public int themDMMangHinh(DMMANGHINH dm)
        {
            return dalDMMangHinh.themDMMangHinh(dm);
        }
        public int xoaDMMangHinh(DMMANGHINH pDMMangHinh)
        {
            return dalDMMangHinh.xoaDMMangHinh(pDMMangHinh);
        }
        public int suaDMMangHinh(DMMANGHINH dm)
        {
            return dalDMMangHinh.suaDMMangHinh(dm);
        }
        public int luuDMMangHinh()
        {
            return dalDMMangHinh.luuDMMangHinh();
        }
        public DMMANGHINH timDMMangHinhTheoMa(int pMaDM, int pMaNV)
        {
            return dalDMMangHinh.timDMMangHinhTheoMa(pMaDM, pMaNV);
        }
        public List<DMMANGHINH> loadDMMangHinhTheoMaNV(int pMaNV)
        {
            return dalDMMangHinh.loadDMMangHinhTheoMaNV(pMaNV);
        }
        public List<DMMANGHINH> loadDMMangHinhTheoMaNV(int pMaNV, bool pChon)
        {
            return dalDMMangHinh.loadDMMangHinhTheoMaNV(pMaNV, pChon);
        }
        public int suaDMMangHinhChon(DMMANGHINH pDMMangHinh, bool pChon)
        {
            return dalDMMangHinh.suaDMMangHinhChon(pDMMangHinh, pChon);
        }
    }
}
