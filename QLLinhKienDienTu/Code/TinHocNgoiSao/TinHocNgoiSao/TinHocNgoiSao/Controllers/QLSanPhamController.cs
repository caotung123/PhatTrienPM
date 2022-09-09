using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TinHocNgoiSao.Models;

namespace TinHocNgoiSao.Controllers
{
    public class QLSanPhamController : Controller
    {
        //
        // GET: /QLSanPham/
        QL_LinhKienDataContext data =new QL_LinhKienDataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Chitietsp(int id)
        {
            THIETBI sp = data.THIETBIs.SingleOrDefault(n => n.MATB == id);
            ViewBag.MASP = sp.MATB;
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sp);
        }
    }
}
