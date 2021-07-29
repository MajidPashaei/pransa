using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataLayer.AdminEntities.Users;
using ViewModels.AdminViewModel.Users;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using pransa.Models;
using DataLayer.AdminEntities.User;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using DataLayer.AdminEntities.Product;
using Microsoft.AspNetCore.Http;
using System.Security.AccessControl;
using DataLayer.AdminEntities;
using Kavenegar;
using Microsoft.AspNetCore.Authorization;
using ViewModels.AdminViewModel.User1;


namespace pransa.Controllers
{
    public class LoginController : BaseController
    {

        public static string msg ;

        public LoginController(ContextHampadco _db, IWebHostEnvironment env) : base(_db, env)
        {

        }


        public IActionResult login()
        {

            return View();
        }


        public IActionResult Register()
        {

            return View();
        }


        public IActionResult verify()
        {
            if (msg != null)
            {
                ViewBag.er=msg;
                msg=null;
            }

            if (HttpContext.Session.GetString("mobile") != null)
            {
                ViewBag.mobile = HttpContext.Session.GetString("mobile");
            }

            var q = db.Tbl_User.Where(a => a.PhoneUs == HttpContext.Session.GetString("mobile")).SingleOrDefault();
            ViewBag.Mobile = mobile;

            return View();
        }
        public IActionResult sendtoken(Vm_User us)
        {
            Random rnd = new Random();
            string number = rnd.Next(1000, 9999).ToString();
            HttpContext.Session.SetString("mobile", us.PhoneUs);
            
            var qcheck = db.Tbl_User.Where(a => a.PhoneUs == us.PhoneUs).SingleOrDefault();
            if (qcheck == null)
            {
                Tb_User user = new Tb_User()
                {
                    PhoneUs = us.PhoneUs,
                    Token = number,

                };
                db.Tbl_User.Add(user);
                db.SaveChanges();

                var api = new KavenegarApi("3871353043697339486A70384F544A4A574C74612B51432F4C7A4B305076645457396F5267456F7A5A34383D");
                api.VerifyLookup(us.PhoneUs, number, "pransa");
                return RedirectToAction("index", "home");

            }
            else
            {
                qcheck.Token = number;
                db.Tbl_User.Update(qcheck);
                db.SaveChanges();

                var api = new KavenegarApi("3871353043697339486A70384F544A4A574C74612B51432F4C7A4B305076645457396F5267456F7A5A34383D");
                api.VerifyLookup(us.PhoneUs, number, "pransa");


                return RedirectToAction("verify");

            }
        }

        public IActionResult checkcode(Vm_User us)
        {
            ViewBag.Mobile= HttpContext.Session.GetString("mobile");
            var q=db.Tbl_User.Where(a =>a.PhoneUs==HttpContext.Session.GetString("mobile")).SingleOrDefault();
            if (q.Token==us.Token)
            {
               var claims = new List<Claim> () {
               new Claim (ClaimTypes.NameIdentifier,q.PhoneUs),
               new Claim (ClaimTypes.Name, "")
               };

               var identity = new ClaimsIdentity (claims, CookieAuthenticationDefaults.AuthenticationScheme);

               var principal = new ClaimsPrincipal (identity);

               var properties = new AuthenticationProperties {
                   ExpiresUtc = DateTime.UtcNow.AddYears(1),
                   IsPersistent = true
               };
               HttpContext.SignInAsync (principal, properties);
               

               return RedirectToAction("index","order");
            }
            else
            {
                msg="کد وردی نادرست است";
                return RedirectToAction("verify");
            }
        }
     }
 }
