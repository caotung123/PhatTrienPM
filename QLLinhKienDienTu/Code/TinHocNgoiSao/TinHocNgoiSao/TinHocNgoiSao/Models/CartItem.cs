using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TinHocNgoiSao.Models
{
    public class CartItem
    {
        public int iMaSP { get; set; }
        public string sTenSP { get; set; }
        public int sLoaiTB { get; set; }
        public string sXuatXu { get; set; }
        public double dGiaBan { get; set; }
        public string sHinh { get; set; }
        public int iSoLuong { get; set; }
        public double ThanhTien
        {
            get { return iSoLuong * dGiaBan; }
        }

        QL_LinhKienDataContext data = new QL_LinhKienDataContext();
        public CartItem(int MaSP)
        {
            THIETBI thietbi = data.THIETBIs.Single(n => n.MATB == MaSP);
            if (thietbi != null)
            {
                iMaSP = MaSP;
                sTenSP = thietbi.TENTB;
                sLoaiTB = int.Parse(thietbi.MALOAI.ToString());
                sXuatXu = thietbi.MOTA;
                dGiaBan = double.Parse(thietbi.GIA.ToString());
                sHinh = thietbi.HINHANH;
                iSoLuong = 1;
            }
        }
    }
}