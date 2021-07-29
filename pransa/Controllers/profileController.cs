using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataLayer.Context;
using DataLayer.AdminEntities.Product;
using pransa.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using DataLayer.AdminEntities.User;
using System.Security.AccessControl;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using DataLayer.AdminEntities;
using Kavenegar;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using ViewModels.AdminViewModel.GalleryProduct;
using ViewModels.AdminViewModel.Users;
using DataLayer.AdminEntities.Users;
using System.IO;
using DataLayer.AdminEntities.Order;
using ViewModels.AdminViewModel.Product;

namespace pransa.Controllers
{
    
    public class profileController : BaseController
    {
        public static string NewFileName;
        public static string msg ;
        
        //--------------type db
        public profileController(ContextHampadco _db,IWebHostEnvironment env):base(_db,env)
        {
            
        }
         
        public IActionResult index()
        {
            ViewBag.list = ShowList();

            var user = db.Tbl_User.Where(a => a.PhoneUs == HttpContext.Session.GetString("mobile")).SingleOrDefault();

            List<Vm_User> vs = new List<Vm_User>();
            Vm_User vuser = new Vm_User()
            {
                UserNameUs = user.UserNameUs ,
                UserFamilyUs = user.UserFamilyUs ,
                NationalCode = user.NationalCode ,
                PhoneUs = user.PhoneUs ,
                AddressUs = user.AddressUs ,
                EmailUS = user.EmailUS ,
                ProfileImageUs = user.ProfileImageUs ,
            };

            vs.Add(vuser);
            ViewBag.us = vs;

            HttpContext.Session.SetString("username", (vuser.UserNameUs+" "+vuser.UserFamilyUs));
            HttpContext.Session.SetString("phone", vuser.PhoneUs);
            if ( vuser.ProfileImageUs != null)
            {
                HttpContext.Session.SetString("photo" , vuser.ProfileImageUs );
            }

            return View();
        }
        
        public IActionResult CheckPardakht()
        {
            var adr = db.Tbl_User.Where(a => a.PhoneUs == User.Identity.GetId()).SingleOrDefault();

            if (adr.AddressUs != null)
            {
                return RedirectToAction("Request" , "Pay");
            }
            else
            {
                msg = " لطفا پروفایل خود را تکمیل کنید " ;
                return RedirectToAction("update");
            }
        }

        public IActionResult Update()
        {
            if (msg != null)
            {
                ViewBag.msg = msg ;
                msg = null;
            }
            var user = db.Tbl_User.Where(a => a.PhoneUs == HttpContext.Session.GetString("mobile")).SingleOrDefault();

            // List<Vm_User> vs = new List<Vm_User>();
            Vm_User vuser = new Vm_User()
            {
                UserNameUs = user.UserNameUs ,
                UserFamilyUs = user.UserFamilyUs ,
                NationalCode = user.NationalCode ,
                PhoneUs = user.PhoneUs ,
                AddressUs = user.AddressUs ,
                EmailUS = user.EmailUS ,
                ProfileImageUs = user.ProfileImageUs ,
            };

            ViewBag.img = vuser;
            
            return View(vuser);
        }
        
        public async Task<IActionResult> updateprofile(Vm_User vs)
        {
            var quser=db.Tbl_User.Where(a=>a.PhoneUs == User.Identity.GetId()).SingleOrDefault();

            quser.UserNameUs = vs.UserNameUs;
            quser.EmailUS = vs.EmailUS;
            quser.AddressUs = vs.AddressUs;
            quser.NationalCode = vs.NationalCode;
            quser.UserFamilyUs = vs.UserFamilyUs;

            if (vs.img != null)
            {
                //--------------------------------------------upload file
                string FileExtension1 = Path.GetExtension(vs.img.FileName);
                NewFileName = String.Concat(Guid.NewGuid().ToString(), FileExtension1);
                var path = $"{_env.WebRootPath}\\fileupload\\{NewFileName}";
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await vs.img.CopyToAsync(stream);
                }
                quser.ProfileImageUs = NewFileName;
            }

            db.Tbl_User.Update(quser);
            db.SaveChanges();

            return RedirectToAction("Index");
            
        }
       
       public IActionResult addadress()
       {

           return View();
       }

        public IActionResult addfavorite(int Id)
        {
            var s = db.Tbl_MyFavorites.Where(a => a.IdKala == Id && a.IdUser== User.Identity.GetId()).FirstOrDefault();
            if (s != null)
            {
                return RedirectToAction("index", "Details" ,  new { id = Id });
            }
            else
            {
                Tbl_MyFavorite Ad = new Tbl_MyFavorite()
                {
                    IdKala = Id,
                    IdUser = User.Identity.GetId(),
                };

                db.Tbl_MyFavorites.Add(Ad);
                db.SaveChanges();
                return RedirectToAction("index", "Details" , new { id = Id });
            }
        }
       
       public IActionResult favorite()
        {
            var ik = db.Tbl_MyFavorites.Where(a => a.IdUser == User.Identity.GetId()).Select( a=> a.IdKala ).ToList();

            // var kala = db.Tbl_Product.Where( a=> a.Id == ik).ToList();

            List<Vm_Product> lvp = new List<Vm_Product>();

            foreach (var item in ik)
            {
                var kala = db.Tbl_Product.Where( a=> a.Id == item).SingleOrDefault();

                Vm_Product vp = new Vm_Product()
                {
                    Id = kala.Id ,
                    TitleProductPro = kala.TitleProductPro ,
                    BrandPro = kala.BrandPro ,
                    PricePro = kala.PricePro ,
                    ImageMainPro = kala.ImageMainPro,
                };
                lvp.Add(vp);
            }

            ViewBag.oll = lvp ;

            return View();
        }


    //    public IActionResult addfavorite()
    //    {

    //        return View();
    //    }
       
       
    }
}