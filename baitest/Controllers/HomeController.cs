using baitest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baitest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            VNR_InternShipEntities db = new VNR_InternShipEntities();
            List<KhoaHoc> kh = new List<KhoaHoc>();
            kh = db.KhoaHocs.ToList();
            return View(kh);
        }
        public ActionResult MonHocs(int id)
        {
            VNR_InternShipEntities db = new VNR_InternShipEntities();
            List<MonHoc> mh = new List<MonHoc>();
            mh = db.MonHocs.Where(p=>p.KhoaHocID==id).ToList();
            return View(mh);
        }
    }
}