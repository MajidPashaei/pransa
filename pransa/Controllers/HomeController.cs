using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.AdminEntities.Blog;
using DataLayer.Context;
using pransa.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using ViewModels.AdminViewModel.SocialNetwork;

namespace pransa.Controllers {
    public class HomeController : BaseController {
        ////////////////////////////////////////////////////type db
        public HomeController (ContextHampadco _db, IWebHostEnvironment env) : base (_db, env) {

        }

        //////////////////////////////////////////////////////////
        public IActionResult Index () {

          
            setdata();
            ViewBag.list = ShowList();
            ////////////////////////////////////////////////////////////////////////////////////////////////address
            var address = db.Tbl_Adress.Where (a => a.Language == ln).ToList ();
            if (address != null) {
                ViewBag.address = address;

            } else {
                ViewBag.address = null;
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////blog

            var blog = db.Tbl_Blog.Where (a => a.Language == ln).OrderByDescending (a => a.Id).Take(4).ToList ();
            if (blog != null) {
                ViewBag.blog = blog;
            }

            //////////////////////////////////////////////////////////////////slider
            var qslider = db.Tbl_Slider.OrderByDescending (a => a.Id).ToList();
            if (qslider != null) {
                ViewBag.slider = qslider;
            }
            //////////////////////////////////////////////////////////////////baner
            var qbaner = db.Tbl_Baner.ToList ();
            if (qbaner != null) 
            {
                ViewBag.baner =qbaner;
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////first_page
            var qfirst = db.tbl_category.Where (a => a.FatherIdCat == -3).ToList();

            List<Tb_Blog> blg = new List<Tb_Blog> ();
            foreach (var item in qfirst) {
                var first = db.Tbl_Blog.Where (a => a.IdCtegoryBlo == item.Id && a.Language == ln).SingleOrDefault ();
                if (first != null) {
                    blg.Add (first);
                }

            }

            if (blg != null) {
                ViewBag.first = blg.OrderByDescending (a => a.Id).Take (2).ToList ();
            }
            
            ///////////////////////////////////////////////////////////////////////////////teaser
            ViewBag.Teaser = db.Tbl_Teaser.Where (a => a.Language == ln).OrderByDescending (a => a.Id).Take (3).ToList ();
            ///////////////////////////////////////////////////////////////////////////////teaser
            ViewBag.social = db.Tbl_SocialNetwork.Where (a => a.Language == ln).OrderByDescending (a => a.Id).ToList ();
            ////////////////////////////////////////////////////////////////////////////////product list
            ViewBag.product = db.Tbl_Product.Where (a => a.Language == ln).OrderByDescending (a => a.Id).Take (6).ToList ();
            //////////////////////////////////////////////////////////////////////////////////expert list
            ViewBag.expert = db.Tbl_Experts.Where (a => a.Language == ln).OrderByDescending (a => a.Id).ToList ();
            //////////////////////////////////////////////////////////////////////////////////expert list
            ViewBag.Discount=db.Tbl_Product.Where(a=>a.MaterialPro=="تخفیف").OrderByDescending (a => a.Id).Take (6).ToList ();
            //////////////////////////////////////////////////////////////////////////////////expert list
            ViewBag.best=db.Tbl_Product.Where(a=>a.MaterialPro=="پرفروش").OrderByDescending (a => a.Id).Take (6).ToList ();
            //////////////////////////////////////////////////////////////////////////////////expert list
            ViewBag.highlight=db.Tbl_Product.Where(a=>a.MaterialPro=="برجسته").OrderByDescending (a => a.Id).Take (6).ToList ();
            //////////////////////////////////////////////////////////////////////////////////expert list
            ViewBag.newpro=db.Tbl_Product.Where(a=>a.MaterialPro=="جدیدترین").OrderByDescending (a => a.Id).Take (6).ToList ();
            //////////////////////////////////////////////////////////////////////////////////expert list
            ViewBag.shegeft=db.Tbl_Product.Where(a=>a.MaterialPro=="پیشنهادشگفت انگیز").OrderByDescending (a => a.Id).Take (6).ToList ();
            //////////////////////////////////////////////////////////////////////////////////expert list
            ViewBag.lahzeh=db.Tbl_Product.Where(a=>a.MaterialPro=="پیشنهادلحظه ای").OrderByDescending (a => a.Id).Take (6).ToList ();
            //////////////////////////////////////////////////////////////////////////////////expert list
            ViewBag.pishnahad=db.Tbl_Product.Where(a=>a.MaterialPro=="پیشنهادما").OrderByDescending (a => a.Id).Take (6).ToList ();

            return View ();
        }

        public IActionResult exit () {
            HttpContext.SignOutAsync (CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction ("index", "home");
        }

        // public IActionResult orgincheck (string id) {
        //      setdata();
        //     var orgin = db.Tbl_Originality.Where (a => a.HologramCodeOri == id).ToList ();
        //     if (orgin.Count () != 0) {
        //         ///////////////////////////////////////////////////////////list

        //         List<Vm_Originality> originality = new List<Vm_Originality> ();
        //         foreach (var item in orgin) {
        //             var product = db.Tbl_Product.Where (a => a.Id == item.IdProductOri).SingleOrDefault ();
        //             Vm_Originality origin = new Vm_Originality () {
        //                 Id = item.Id,
        //                 nameproduct = product.TitleProductPro,
        //                 HologramCodeOri = item.HologramCodeOri,
        //                 NumberProductOri = item.NumberProductOri,
        //                 Language = item.Language,
        //                 DateCreateOri = item.DateCreateOri,
        //                 img = product.ImageMainPro,
        //                 IdProductOri=product.Id
        //             };
        //             originality.Add (origin);

        //         }

        //         ViewBag.listp = originality.OrderByDescending (a => a.Id).ToList ();
        //         //////////////////////////////////////////////////////////
        //     } else {
        //         error = "چنین کد هولوگرامی در شرکت سون استار ثبت نشده است";
        //         return RedirectToAction ("orgin");
        //     }
        //     return View ();
        // }

        // [Authorize]
        public IActionResult orgin () 
        {
            ViewBag.list = ShowList();
            if (error != null) {
                ViewBag.e = error;
                error = null;
            }
            return View ();
        }


        ///////////////////////////////////////////addshop
        public IActionResult addshop (int id) {
            
            ViewBag.list = ShowList();

            string a=HttpContext.Session.GetString ("shop");

            if ( a != null)
            {
                 HttpContext.Session.SetString ("shop",a+id.ToString()+",");
            }else
            {
                HttpContext.Session.SetString ("shop",id.ToString()+",");
            }
            

           
            return RedirectToAction ("index");
        }

        public IActionResult search(string myInput)
        {
            ViewBag.list = ShowList();
            ViewBag.oll=db.Tbl_Product.Where(a=>a.TitleProductPro.Contains(myInput)).ToList();

            return View();
        }
        public IActionResult searchcat(int Id)
        {
            ViewBag.list = ShowList();
            ViewBag.cat=db.Tbl_Product.Where(a =>a.CategoryIdPro==Id.ToString()).ToList();
            return View();
        }
    }
}