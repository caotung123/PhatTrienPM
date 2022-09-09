using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TinHocNgoiSao.Models;
namespace TinHocNgoiSao.Controllers
{
    public class TinHocNgoiSaoController : Controller
    {
        //
        // GET: /Home/
        QL_LinhKienDataContext data = new QL_LinhKienDataContext();
        public ActionResult Home()
        {
            List<THIETBI> dstl = data.THIETBIs.Take(4).ToList();
            return View(dstl);
        }
        public ActionResult HTTENLOAI()
        {
            List<LOAITB> dsL = data.LOAITBs.ToList();
            return PartialView(dsL);
        }
        public ActionResult HTSP(int ml)
        {
            List<THIETBI> dsSP = data.THIETBIs.Where(t => t.MALOAI == ml).ToList();
            ViewBag.lst1 = dsSP;
            return View("Home", dsSP);
        }
        [HttpPost]//bắt buộc có để tìm kiếm
        public ActionResult XuLiTK(FormCollection col)
        {
            string tk = col["txtTuKhoa"].ToString();

            List<THIETBI> dsS = data.THIETBIs.Where(s => s.TENTB.Contains(tk) == true).ToList();

            return View("Home", dsS);
        }
        public ActionResult ChiTietSP(int id)
        {
            THIETBI s = data.THIETBIs.FirstOrDefault(t => t.MATB == id);

            return View(s);
        }
        [HttpGet]
        public ActionResult DangNhap()
        {

            return View();
        }
        [HttpPost]
        public ActionResult XLDN(FormCollection co)
        {
            string ten = co["txtTendn"];
            string matkhau = co["txtPass"];
            KHACHHANG kh = data.KHACHHANGs.SingleOrDefault(k => k.TaiKhoan == ten && k.MatKhau == matkhau);
            if (kh == null)
            {
                return View();
            }

            Session["khachhang"] = kh;
            return RedirectToAction("Home", "TinHocNgoiSao");
        }
        public ActionResult DangXuat()
        {
            Session["khachhang"] = null;
            return RedirectToAction("Home", "TinHocNgoiSao");
        }
        public ActionResult XemGioHang()
        {
            GioHang gh = (GioHang)Session["gh"];
            return View(gh);
        }
        public ActionResult ThemMatHang(int id)
        {
            GioHang gh = (GioHang)Session["gh"];
            if (gh == null)
            {
                gh = new GioHang();
            }
            gh.Them(id);
            Session["gh"] = gh;

            return RedirectToAction("Home", "TinHocNgoiSao");

        }
        public ActionResult XoaMatHang(int id)
        {
            GioHang gh = (GioHang)Session["gh"];
            if (gh == null)
            {
                gh = new GioHang();
            }
            gh.Xoa(id);
            Session["gh"] = gh;

            return RedirectToAction("XemGioHang", "TinHocNgoiSao");

        }
        public ActionResult XoaGioHang()
        {
            GioHang gh = (GioHang)Session["gh"];
            if (gh == null)
            {
                gh = new GioHang();
            }
            gh.XoaGioHang();
            Session["gh"] = gh;

            return RedirectToAction("XemGioHang", "TinHocNgoiSao");

        }
        public ActionResult XacNhanDongHang()
        {
            KHACHHANG kh = Session["khachhang"] as KHACHHANG;
            if (kh == null)
            {
                return RedirectToAction("DangNhap", "TinHocNgoiSao");
            }
            return View(kh);
        }
        [HttpPost]
        public ActionResult LuuDatHang(FormCollection co)
        {
            GioHang gh = (GioHang)Session["gh"];
            KHACHHANG kh = (KHACHHANG)Session["khachhang"];
            if (Session["khachhang"] == null)
                return RedirectToAction("Home", "TinHocNgoiSao");
            if (Session["gh"] == null || gh.lst.Count == 0)
                return RedirectToAction("XemGioHang", "TinHocNgoiSao");
            string ngaygiao = co["txtDate"];

            DONHANG hd = new DONHANG();
            hd.MAKH = kh.MAKH;
            hd.NGAYLAP = DateTime.Now;
            data.DONHANGs.InsertOnSubmit(hd);
            data.SubmitChanges();
            foreach (CartItem sp in gh.lst)
            {
                CTDONHANG ct = new CTDONHANG();
                ct.MADH = hd.MADH;
                ct.MATB = sp.iMaSP;
                ct.SOLUONG = sp.iSoLuong;
                data.CTDONHANGs.InsertOnSubmit(ct);
            }
            data.SubmitChanges();
            gh.XoaGioHang();
            return View();
        }
    }
}
   