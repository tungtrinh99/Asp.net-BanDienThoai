using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BanDienThoai.Models;
using System.Net;
using System.Data.Entity;
using PagedList;
using PagedList.Mvc;


namespace BanDienThoai.Controllers
{
    public class HomeController : Controller
    {
        DienThoaiEntities db = new DienThoaiEntities();
        
        public ActionResult Index(int? page)
        {
            if (page == null) page = 1;

            
            var dienthoai = (from l in db.DMDienThoais
                         select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            return View(dienthoai.ToList().ToPagedList(pageNumber, pagesize));
        }
        public ViewResult XemChiTiet(string MaDienThoai = "BK01")
        {
            DMDienThoai sanpham = db.DMDienThoais.SingleOrDefault(n => n.MaDienThoai == MaDienThoai);
            if (sanpham == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sanpham);
        }
        public ActionResult iPhone(string sortOrder, int? page, string sortOrder1)
        {
            
            ViewBag.CurrentSort = sortOrder;
            ViewBag.GiamSortParm = String.IsNullOrEmpty(sortOrder) ? "giam" : "giam";
            ViewBag.TangSortParm = String.IsNullOrEmpty(sortOrder) ? "tang" : "tang";
            ViewBag.azSortParm = String.IsNullOrEmpty(sortOrder) ? "az" : "az";
            ViewBag.zaSortParm = String.IsNullOrEmpty(sortOrder) ? "za" : "za";
            ViewBag.ios = String.IsNullOrEmpty(sortOrder1) ? "ios" : "ios";
            ViewBag.bos = String.IsNullOrEmpty(sortOrder1) ? "bos" : "bos";
            ViewBag.emui = String.IsNullOrEmpty(sortOrder1) ? "emui" : "emui";
            ViewBag.apk = String.IsNullOrEmpty(sortOrder1) ? "apk" : "apk";
            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            switch (sortOrder)
            {
                case "giam":
                    dienthoai = dienthoai.OrderByDescending(s => s.DonGiaBan);
                    break;
                case "tang":
                    dienthoai = dienthoai.OrderBy(s => s.DonGiaBan);
                    break;
                case "za":
                    dienthoai = dienthoai.OrderByDescending(s => s.TenDienThoai);
                    break;
                case "az":
                    dienthoai = dienthoai.OrderBy(s => s.TenDienThoai);
                    break;
            }
            switch (sortOrder1)
            {
                case "ios":
                    dienthoai = dienthoai.OrderByDescending(s => s.DonGiaBan);
                    break;
                case "bos":
                    dienthoai = dienthoai.OrderBy(s => s.DonGiaBan);
                    break;
                case "apk":
                    dienthoai = dienthoai.OrderByDescending(s => s.TenDienThoai);
                    break;
                case "emui":
                    dienthoai = dienthoai.OrderBy(s => s.TenDienThoai);
                    break;
            }

            return View(dienthoai.Where(p => p.MaHangSX == "HSX02").ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult hUawei(string sortOrder, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.GiamSortParm = String.IsNullOrEmpty(sortOrder) ? "giam" : "giam";
            ViewBag.TangSortParm = String.IsNullOrEmpty(sortOrder) ? "tang" : "tang";
            ViewBag.azSortParm = String.IsNullOrEmpty(sortOrder) ? "az" : "az";
            ViewBag.zaSortParm = String.IsNullOrEmpty(sortOrder) ? "za" : "za";
            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            switch (sortOrder)
            {
                case "giam":
                    dienthoai = dienthoai.OrderByDescending(s => s.DonGiaBan);
                    break;
                case "tang":
                    dienthoai = dienthoai.OrderBy(s => s.DonGiaBan);
                    break;
                case "za":
                    dienthoai = dienthoai.OrderByDescending(s => s.TenDienThoai);
                    break;
                case "az":
                    dienthoai = dienthoai.OrderBy(s => s.TenDienThoai);
                    break;
            }

            return View(dienthoai.Where(p => p.MaHangSX == "HSX06").ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult lG(string sortOrder, int? page)
        {
            
            ViewBag.CurrentSort = sortOrder;
            ViewBag.GiamSortParm = String.IsNullOrEmpty(sortOrder) ? "giam" : "giam";
            ViewBag.TangSortParm = String.IsNullOrEmpty(sortOrder) ? "tang" : "tang";
            ViewBag.azSortParm = String.IsNullOrEmpty(sortOrder) ? "az" : "az";
            ViewBag.zaSortParm = String.IsNullOrEmpty(sortOrder) ? "za" : "za";
           
            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            switch (sortOrder)
            {
                case "giam":
                    dienthoai = dienthoai.OrderByDescending(s => s.DonGiaBan);
                    break;
                case "tang":
                    dienthoai = dienthoai.OrderBy(s => s.DonGiaBan);
                    break;
                case "za":
                    dienthoai = dienthoai.OrderByDescending(s => s.TenDienThoai);
                    break;
                case "az":
                    dienthoai = dienthoai.OrderBy(s => s.TenDienThoai);
                    break;
            }
           
            return View(dienthoai.Where(p => p.MaHangSX == "HSX07").ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult samSung(string sortOrder, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.GiamSortParm = String.IsNullOrEmpty(sortOrder) ? "giam" : "giam";
            ViewBag.TangSortParm = String.IsNullOrEmpty(sortOrder) ? "tang" : "tang";
            ViewBag.azSortParm = String.IsNullOrEmpty(sortOrder) ? "az" : "az";
            ViewBag.zaSortParm = String.IsNullOrEmpty(sortOrder) ? "za" : "za";
            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            switch (sortOrder)
            {
                case "giam":
                    dienthoai = dienthoai.OrderByDescending(s => s.DonGiaBan);
                    break;
                case "tang":
                    dienthoai = dienthoai.OrderBy(s => s.DonGiaBan);
                    break;
                case "za":
                    dienthoai = dienthoai.OrderByDescending(s => s.TenDienThoai);
                    break;
                case "az":
                    dienthoai = dienthoai.OrderBy(s => s.TenDienThoai);
                    break;
            }
            return View(dienthoai.Where(p => p.MaHangSX == "HSX01").ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult bPhone(string sortOrder, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.GiamSortParm = String.IsNullOrEmpty(sortOrder) ? "giam" : "giam";
            ViewBag.TangSortParm = String.IsNullOrEmpty(sortOrder) ? "tang" : "tang";
            ViewBag.azSortParm = String.IsNullOrEmpty(sortOrder) ? "az" : "az";
            ViewBag.zaSortParm = String.IsNullOrEmpty(sortOrder) ? "za" : "za";
            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            switch (sortOrder)
            {
                case "giam":
                    dienthoai = dienthoai.OrderByDescending(s => s.DonGiaBan);
                    break;
                case "tang":
                    dienthoai = dienthoai.OrderBy(s => s.DonGiaBan);
                    break;
                case "za":
                    dienthoai = dienthoai.OrderByDescending(s => s.TenDienThoai);
                    break;
                case "az":
                    dienthoai = dienthoai.OrderBy(s => s.TenDienThoai);
                    break;
            }
            return View( dienthoai.Where(p => p.MaHangSX == "HSX04").ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult vsMart( string sortOrder, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.GiamSortParm = String.IsNullOrEmpty(sortOrder) ? "giam" : "giam";
            ViewBag.TangSortParm = String.IsNullOrEmpty(sortOrder) ? "tang" : "tang";
            ViewBag.azSortParm = String.IsNullOrEmpty(sortOrder) ? "az" : "az";
            ViewBag.zaSortParm = String.IsNullOrEmpty(sortOrder) ? "za" : "za";
            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            
            

            switch (sortOrder)
            {
                case "giam":
                    dienthoai = dienthoai.OrderByDescending(s => s.DonGiaBan);
                    break;
                case "tang":
                    dienthoai = dienthoai.OrderBy(s => s.DonGiaBan);
                    break;
                case "za":
                    dienthoai = dienthoai.OrderByDescending(s => s.TenDienThoai);
                    break;
                case "az":
                    dienthoai = dienthoai.OrderBy(s => s.TenDienThoai);
                    break;
            }
            return View(dienthoai.Where(p => p.MaHangSX == "HSX03").ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult xiaoMi(string sortOrder, int? page)
        {
            
            ViewBag.CurrentSort = sortOrder;
            ViewBag.GiamSortParm = String.IsNullOrEmpty(sortOrder) ? "giam" : "giam";
            ViewBag.TangSortParm = String.IsNullOrEmpty(sortOrder) ? "tang" : "tang";
            ViewBag.azSortParm = String.IsNullOrEmpty(sortOrder) ? "az" : "az";
            ViewBag.zaSortParm = String.IsNullOrEmpty(sortOrder) ? "za" : "za";
           
            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            
            switch (sortOrder)
            {
                case "giam":
                    dienthoai = dienthoai.OrderByDescending(s => s.DonGiaBan);
                    break;
                case "tang":
                    dienthoai = dienthoai.OrderBy(s => s.DonGiaBan);
                    break;
                case "za":
                    dienthoai = dienthoai.OrderByDescending(s => s.TenDienThoai);
                    break;
                case "az":
                    dienthoai = dienthoai.OrderBy(s => s.TenDienThoai);
                    break;
            }
            return View( dienthoai.Where(p => p.MaHangSX == "HSX05").ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult Duoi3trieu(string sortOrder,int? page)

        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.GiamSortParm = String.IsNullOrEmpty(sortOrder) ? "giam" : "giam";
            ViewBag.TangSortParm = String.IsNullOrEmpty(sortOrder) ? "tang" : "tang";
            ViewBag.azSortParm = String.IsNullOrEmpty(sortOrder) ? "az" : "az";
            ViewBag.zaSortParm = String.IsNullOrEmpty(sortOrder) ? "za" : "za";
            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            switch (sortOrder)
            {
                case "giam":
                    dienthoai = dienthoai.OrderByDescending(s => s.DonGiaBan);
                    break;
                case "tang":
                    dienthoai = dienthoai.OrderBy(s => s.DonGiaBan);
                    break;
                case "za":
                    dienthoai = dienthoai.OrderByDescending(s => s.TenDienThoai);
                    break;
                case "az":
                    dienthoai = dienthoai.OrderBy(s => s.TenDienThoai);
                    break;
            }
            return View(dienthoai.Where(p => p.DonGiaBan < 3000000).ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult baden6trieu(string sortOrder, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.GiamSortParm = String.IsNullOrEmpty(sortOrder) ? "giam" : "giam";
            ViewBag.TangSortParm = String.IsNullOrEmpty(sortOrder) ? "tang" : "tang";
            ViewBag.azSortParm = String.IsNullOrEmpty(sortOrder) ? "az" : "az";
            ViewBag.zaSortParm = String.IsNullOrEmpty(sortOrder) ? "za" : "za";
            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            switch (sortOrder)
            {
                case "giam":
                    dienthoai = dienthoai.OrderByDescending(s => s.DonGiaBan);
                    break;
                case "tang":
                    dienthoai = dienthoai.OrderBy(s => s.DonGiaBan);
                    break;
                case "za":
                    dienthoai = dienthoai.OrderByDescending(s => s.TenDienThoai);
                    break;
                case "az":
                    dienthoai = dienthoai.OrderBy(s => s.TenDienThoai);
                    break;
            }
            return View(dienthoai.Where(p => p.DonGiaBan >= 3000000 & p.DonGiaBan< 6000000).ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult sauden9trieu(string sortOrder, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.GiamSortParm = String.IsNullOrEmpty(sortOrder) ? "giam" : "giam";
            ViewBag.TangSortParm = String.IsNullOrEmpty(sortOrder) ? "tang" : "tang";
            ViewBag.azSortParm = String.IsNullOrEmpty(sortOrder) ? "az" : "az";
            ViewBag.zaSortParm = String.IsNullOrEmpty(sortOrder) ? "za" : "za";
            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            switch (sortOrder)
            {
                case "giam":
                    dienthoai = dienthoai.OrderByDescending(s => s.DonGiaBan);
                    break;
                case "tang":
                    dienthoai = dienthoai.OrderBy(s => s.DonGiaBan);
                    break;
                case "za":
                    dienthoai = dienthoai.OrderByDescending(s => s.TenDienThoai);
                    break;
                case "az":
                    dienthoai = dienthoai.OrderBy(s => s.TenDienThoai);
                    break;
            }
            return View(dienthoai.Where(p => p.DonGiaBan >= 6000000 & p.DonGiaBan < 9000000).ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult chinden12trieu(string sortOrder, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.GiamSortParm = String.IsNullOrEmpty(sortOrder) ? "giam" : "giam";
            ViewBag.TangSortParm = String.IsNullOrEmpty(sortOrder) ? "tang" : "tang";
            ViewBag.azSortParm = String.IsNullOrEmpty(sortOrder) ? "az" : "az";
            ViewBag.zaSortParm = String.IsNullOrEmpty(sortOrder) ? "za" : "za";
            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            switch (sortOrder)
            {
                case "giam":
                    dienthoai = dienthoai.OrderByDescending(s => s.DonGiaBan);
                    break;
                case "tang":
                    dienthoai = dienthoai.OrderBy(s => s.DonGiaBan);
                    break;
                case "za":
                    dienthoai = dienthoai.OrderByDescending(s => s.TenDienThoai);
                    break;
                case "az":
                    dienthoai = dienthoai.OrderBy(s => s.TenDienThoai);
                    break;
            }
            return View(dienthoai.Where(p => p.DonGiaBan >= 9000000 & p.DonGiaBan < 12000000).ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult tren12trieu(string sortOrder, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.GiamSortParm = String.IsNullOrEmpty(sortOrder) ? "giam" : "giam";
            ViewBag.TangSortParm = String.IsNullOrEmpty(sortOrder) ? "tang" : "tang";
            ViewBag.azSortParm = String.IsNullOrEmpty(sortOrder) ? "az" : "az";
            ViewBag.zaSortParm = String.IsNullOrEmpty(sortOrder) ? "za" : "za";
            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            switch (sortOrder)
            {
                case "giam":
                    dienthoai = dienthoai.OrderByDescending(s => s.DonGiaBan);
                    break;
                case "tang":
                    dienthoai = dienthoai.OrderBy(s => s.DonGiaBan);
                    break;
                case "za":
                    dienthoai = dienthoai.OrderByDescending(s => s.TenDienThoai);
                    break;
                case "az":
                    dienthoai = dienthoai.OrderBy(s => s.TenDienThoai);
                    break;
            }
            return View(dienthoai.Where(p => p.DonGiaBan >= 12000000).ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult giamdan(string sortOrder, int? page)
        {
            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            ViewBag.GiaSortParm = String.IsNullOrEmpty(sortOrder) ? "gia_desc" : "";
            var gia = from s in db.DMDienThoais
                        select s;
            switch (sortOrder)
            {
                
                case "gia_desc":
                    gia = gia.OrderByDescending(s => s.DonGiaBan);
                    break;

                
                default:
                    gia = gia.OrderByDescending(s => s.DonGiaBan);
                    break;
            }
            return View( gia.ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult tangdan(string sortOrder, int? page)
        {
            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            ViewBag.GiaSortParm = String.IsNullOrEmpty(sortOrder) ? "gia_asc" : "";
            var gia = from s in db.DMDienThoais
                      select s;
            switch (sortOrder)
            {

                case "gia_asc":
                    gia = gia.OrderBy(s => s.DonGiaBan);
                    break;


                default:
                    gia = gia.OrderBy(s => s.DonGiaBan);
                    break;
            }
            return View(gia.ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult az(string sortOrder, int? page)
        {
            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            ViewBag.azSortParm = String.IsNullOrEmpty(sortOrder) ? "az_asc" : "";
            var az = from s in db.DMDienThoais
                      select s;
            switch (sortOrder)
            {

                case "az_asc":
                    az = az.OrderBy(s => s.TenDienThoai);
                    break;


                default:
                    az = az.OrderBy(s => s.TenDienThoai);
                    break;
            }
            return View(az.ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult za(string sortOrder, int? page)
        {
            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            ViewBag.zaSortParm = String.IsNullOrEmpty(sortOrder) ? "az_desc" : "";
            var za = from s in db.DMDienThoais
                     select s;
            switch (sortOrder)
            {

                case "az_desc":
                    za = za.OrderByDescending(s => s.TenDienThoai);
                    break;


                default:
                    za = za.OrderByDescending(s => s.TenDienThoai);
                    break;
            }
            return View(za.ToList().ToPagedList(pageNumber, pagesize));
        }
        


        public ViewResult timkiem(string searchString, string sortOrder, int? page, string TimKiem)
        {
            
            ViewBag.CurrentSort = sortOrder;
            ViewBag.GiamSortParm = String.IsNullOrEmpty(sortOrder) ? "giam" : "giam";
            ViewBag.TangSortParm = String.IsNullOrEmpty(sortOrder) ? "tang" : "tang";
            ViewBag.azSortParm = String.IsNullOrEmpty(sortOrder) ? "az" : "az";
            ViewBag.zaSortParm = String.IsNullOrEmpty(sortOrder) ? "za" : "za";
            if (page == null) page = 1;

            int pagesize = 5;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            var dienthoai = from l in db.DMDienThoais
                            select l;
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = TimKiem;
            }
            ViewBag.TimKiem = searchString;


            if (!String.IsNullOrEmpty(searchString))
            {
                dienthoai = dienthoai.Where(s => s.TenDienThoai.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "giam":
                    dienthoai = dienthoai.OrderByDescending(s => s.DonGiaBan);
                    break;
                case "tang":
                    dienthoai = dienthoai.OrderBy(s => s.DonGiaBan);
                    break;
                case "za":
                    dienthoai = dienthoai.OrderByDescending(s => s.TenDienThoai);
                    break;
                case "az":
                    dienthoai = dienthoai.OrderBy(s => s.TenDienThoai);
                    break;
            }


            if (dienthoai.ToList().Count == 0)
            {
                ViewBag.ThongBao1 = "Không có sản phẩm bạn tìm kiếm";
                return View(dienthoai.ToList().ToPagedList(pageNumber, pagesize));
            }

            ViewBag.ThongBao1 = "Đã tìm thấy " + dienthoai.ToList().Count + " sản phẩm";
            return View(dienthoai.ToList().ToPagedList(pageNumber, pagesize));
        
    }
        public ViewResult XemBanDo1()
        {
            return View();
        }
        public ViewResult XemBanDo2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KetQuaTimKiem(FormCollection f, int? page)
        {


            List<DMDienThoai> lstKQTK;
            string searchKey = f["txtTimkiem"].ToString();
            string searchKey2 = f["MaNuocSX"].ToString();
            string searchKey3 = f["MaHangSX"].ToString();
            string searchKey4 = f["MaRam"].ToString();
            string searchKey5 = f["MaRom"].ToString();
            string searchKey6 = f["MaHeDieuHanh"].ToString();
            string searchKey7 = f["MaGiaTien"].ToString();

            ViewBag.keyword = searchKey;
            ViewBag.keyword2 = searchKey2;
            ViewBag.keyword3 = searchKey3;
            ViewBag.keyword4 = searchKey4;
            ViewBag.keyword5 = searchKey5;
            ViewBag.keyword6 = searchKey6;
            ViewBag.keyword7 = searchKey7;
            if (searchKey != "" || searchKey != null)
            {
                lstKQTK = db.DMDienThoais.Where(n => n.TenDienThoai.Contains(searchKey)).ToList();


            }
            else
            {
                lstKQTK = db.DMDienThoais.ToList();

            }

            if (searchKey2.Trim() != "ALL")
            {
                lstKQTK = lstKQTK.Where(n => n.MaNuocSX == searchKey2).ToList();

            }
            if (searchKey3.Trim() != "ALL")
            {
                lstKQTK = lstKQTK.Where(n => n.MaHangSX == searchKey3).ToList();

            }
            if (searchKey4.Trim() != "ALL" )
            {
                lstKQTK = lstKQTK.Where(n => n.MaRam == searchKey4).ToList();

            }
            if (searchKey5.Trim() != "ALL" )
            {
                lstKQTK = lstKQTK.Where(n => n.MaRom == searchKey5).ToList();

            }
            if (searchKey6.Trim() != "ALL" )
            {
                lstKQTK = lstKQTK.Where(n => n.MaHeDieuHanh == searchKey6).ToList();

            }
            if (searchKey7.Trim() != "ALL")
            {
                lstKQTK = lstKQTK.Where(n => n.MaGiaTien == searchKey7).ToList();

            }




            int pageNumber = (page ?? 1);
            int pageSize = 10;
            if (lstKQTK.Count == 0)
            {
                ViewBag.ThongBao = "Không có sản phẩm bạn tìm kiếm";
                return View(lstKQTK.OrderBy(n => n.TenDienThoai).ToList().ToPagedList(pageNumber, pageSize));
            }
            ViewBag.ThongBao = "Đã tìm thấy " + lstKQTK.Count + " sản phẩm";
            return View(lstKQTK.OrderBy(n => n.TenDienThoai).ToList().ToPagedList(pageNumber, pageSize));



        }
        [HttpGet]
        public ActionResult KetQuaTimKiem(int? page, string searchKey, string searchKey2, string searchKey3, string searchKey4, string searchKey5, string searchKey6, string searchKey7)
        {

            List<DMDienThoai> lstKQTK;
            ViewBag.MaNuocSX = new SelectList(db.NuocSanXuats.ToList().OrderBy(n => n.TenNuocSX), "MaNuocSX", "TenNuocSX");
            ViewBag.MaHangSX = new SelectList(db.HangSanXuats.ToList().OrderBy(n => n.TenHangSx), "MaHangSX", "TenHangSx");
            ViewBag.MaRam = new SelectList(db.Ramms.ToList().OrderBy(n => n.BoNhoRam), "MaRam", "BoNhoRam");
            ViewBag.MaRom = new SelectList(db.Roms.ToList().OrderBy(n => n.BoNhoRom), "MaRom", "BoNhoRom");
            ViewBag.MaHeDieuHanh = new SelectList(db.HeDieuHanhs.ToList().OrderBy(n => n.TenHeDieuHanh), "MaHeDieuHanh", "TenHeDieuHanh");
            ViewBag.MaGiaTien = new SelectList(db.Tiens.ToList().OrderBy(n => n.GiaTien), "MaGiaTien", "GiaTien");



            ViewBag.keyword = searchKey;
            ViewBag.keyword2 = searchKey2;
            ViewBag.keyword3 = searchKey3;
            ViewBag.keyword4 = searchKey4;
            ViewBag.keyword5 = searchKey5;
            ViewBag.keyword6 = searchKey6;
            ViewBag.keyword7 = searchKey7;

            if (searchKey == null)
            {
                lstKQTK = db.DMDienThoais.ToList();

            }
            else
            {
                lstKQTK = db.DMDienThoais.Where(n => n.TenDienThoai.Contains(searchKey)).ToList();

            }

            if (searchKey2.Trim() != "ALL")
            {
                lstKQTK = lstKQTK.Where(n => n.MaNuocSX == searchKey2).ToList();

            }
            if (searchKey3.Trim() != "ALL")
            {
                lstKQTK = lstKQTK.Where(n => n.MaHangSX == searchKey3).ToList();

            }
            if (searchKey4.Trim() != "ALL" )
            {
                lstKQTK = lstKQTK.Where(n => n.MaRam == searchKey4).ToList();

            }
            if (searchKey5.Trim() != "ALL" )
            {
                lstKQTK = lstKQTK.Where(n => n.MaRom == searchKey5).ToList();

            }
            if (searchKey6.Trim() != "ALL" )
            {
                lstKQTK = lstKQTK.Where(n => n.MaHeDieuHanh == searchKey6).ToList();

            }
            if (searchKey7.Trim() != "ALL")
            {
                lstKQTK = lstKQTK.Where(n => n.MaGiaTien == searchKey7).ToList();

            }


            int pageNumber = (page ?? 1);
            int pageSize = 10;
            if (lstKQTK.Count == 0)
            {
                ViewBag.ThongBao = "Không có sản phẩm bạn tìm kiếm";
                return View(lstKQTK.OrderBy(n => n.TenDienThoai).ToList().ToPagedList(pageNumber, pageSize));
            }
            ViewBag.ThongBao = "Đã tìm thấy "+ lstKQTK.Count+ " sản phẩm";
            return View(lstKQTK.OrderBy(n => n.TenDienThoai).ToList().ToPagedList(pageNumber, pageSize));




        }
        public ActionResult Index1(int? page)
        {
            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);
            return View(dienthoai.ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult bos(string sortOrder, int? page)
        {

            ViewBag.CurrentSort = sortOrder;
            ViewBag.GiamSortParm = String.IsNullOrEmpty(sortOrder) ? "giam" : "giam";
            ViewBag.TangSortParm = String.IsNullOrEmpty(sortOrder) ? "tang" : "tang";
            ViewBag.azSortParm = String.IsNullOrEmpty(sortOrder) ? "az" : "az";
            ViewBag.zaSortParm = String.IsNullOrEmpty(sortOrder) ? "za" : "za";

            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);

            switch (sortOrder)
            {
                case "giam":
                    dienthoai = dienthoai.OrderByDescending(s => s.DonGiaBan);
                    break;
                case "tang":
                    dienthoai = dienthoai.OrderBy(s => s.DonGiaBan);
                    break;
                case "za":
                    dienthoai = dienthoai.OrderByDescending(s => s.TenDienThoai);
                    break;
                case "az":
                    dienthoai = dienthoai.OrderBy(s => s.TenDienThoai);
                    break;
            }
            return View(dienthoai.Where(p => p.MaHeDieuHanh == "bos").ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult apk(string sortOrder, int? page)
        {

            ViewBag.CurrentSort = sortOrder;
            ViewBag.GiamSortParm = String.IsNullOrEmpty(sortOrder) ? "giam" : "giam";
            ViewBag.TangSortParm = String.IsNullOrEmpty(sortOrder) ? "tang" : "tang";
            ViewBag.azSortParm = String.IsNullOrEmpty(sortOrder) ? "az" : "az";
            ViewBag.zaSortParm = String.IsNullOrEmpty(sortOrder) ? "za" : "za";

            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);

            switch (sortOrder)
            {
                case "giam":
                    dienthoai = dienthoai.OrderByDescending(s => s.DonGiaBan);
                    break;
                case "tang":
                    dienthoai = dienthoai.OrderBy(s => s.DonGiaBan);
                    break;
                case "za":
                    dienthoai = dienthoai.OrderByDescending(s => s.TenDienThoai);
                    break;
                case "az":
                    dienthoai = dienthoai.OrderBy(s => s.TenDienThoai);
                    break;
            }
            return View(dienthoai.Where(p => p.MaHeDieuHanh == "apk").ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult ios(string sortOrder, int? page)
        {

            ViewBag.CurrentSort = sortOrder;
            ViewBag.GiamSortParm = String.IsNullOrEmpty(sortOrder) ? "giam" : "giam";
            ViewBag.TangSortParm = String.IsNullOrEmpty(sortOrder) ? "tang" : "tang";
            ViewBag.azSortParm = String.IsNullOrEmpty(sortOrder) ? "az" : "az";
            ViewBag.zaSortParm = String.IsNullOrEmpty(sortOrder) ? "za" : "za";

            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);

            switch (sortOrder)
            {
                case "giam":
                    dienthoai = dienthoai.OrderByDescending(s => s.DonGiaBan);
                    break;
                case "tang":
                    dienthoai = dienthoai.OrderBy(s => s.DonGiaBan);
                    break;
                case "za":
                    dienthoai = dienthoai.OrderByDescending(s => s.TenDienThoai);
                    break;
                case "az":
                    dienthoai = dienthoai.OrderBy(s => s.TenDienThoai);
                    break;
            }
            return View(dienthoai.Where(p => p.MaHeDieuHanh == "ios").ToList().ToPagedList(pageNumber, pagesize));
        }
        public ActionResult emui(string sortOrder, int? page)
        {

            ViewBag.CurrentSort = sortOrder;
            ViewBag.GiamSortParm = String.IsNullOrEmpty(sortOrder) ? "giam" : "giam";
            ViewBag.TangSortParm = String.IsNullOrEmpty(sortOrder) ? "tang" : "tang";
            ViewBag.azSortParm = String.IsNullOrEmpty(sortOrder) ? "az" : "az";
            ViewBag.zaSortParm = String.IsNullOrEmpty(sortOrder) ? "za" : "za";

            if (page == null) page = 1;


            var dienthoai = (from l in db.DMDienThoais
                             select l).OrderBy(x => x.MaDienThoai);
            int pagesize = 10;// so sp tren mot trang
            int pageNumber = (page ?? 1);

            switch (sortOrder)
            {
                case "giam":
                    dienthoai = dienthoai.OrderByDescending(s => s.DonGiaBan);
                    break;
                case "tang":
                    dienthoai = dienthoai.OrderBy(s => s.DonGiaBan);
                    break;
                case "za":
                    dienthoai = dienthoai.OrderByDescending(s => s.TenDienThoai);
                    break;
                case "az":
                    dienthoai = dienthoai.OrderBy(s => s.TenDienThoai);
                    break;
            }
            return View(dienthoai.Where(p => p.MaHeDieuHanh == "emui").ToList().ToPagedList(pageNumber, pagesize));
        }
    }    
}
