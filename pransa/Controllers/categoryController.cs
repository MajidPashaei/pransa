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

namespace pransa.Controllers
{
    
    public class categoryController :BaseController
    {
        
           ////////////////////////////////////////////type db
        public categoryController(ContextHampadco _db,IWebHostEnvironment env):base(_db,env)
        {
            
        }
         
         
       

        public IActionResult index(int id)
        {
            ViewBag.list = ShowList();
            ViewBag.B=db.Tbl_Product.Where (a =>Convert.ToInt32(a.CategoryIdPro)==id).ToList();

           
            return View();
        }

       
        public IActionResult Discount()
        {
            ViewBag.list = ShowList();
            ViewBag.Discount=db.Tbl_Product.Where(a=>a.MaterialPro=="تخفیف").OrderByDescending (a => a.Id).ToList();            
            return View();
        }
       
        
      public IActionResult best( )
        {
            ViewBag.list = ShowList();            
            ViewBag.best=db.Tbl_Product.Where(a=>a.MaterialPro=="پرفروش").OrderByDescending (a => a.Id).ToList();

            
            return View();
        }
        public IActionResult highlight( )
        {
            ViewBag.list = ShowList();
             ViewBag.highlight=db.Tbl_Product.Where(a=>a.MaterialPro=="برجسته").OrderByDescending (a => a.Id).ToList();

            
            return View();
        }
        public IActionResult newpro( )
        {
            ViewBag.list = ShowList();
                        ViewBag.newpro=db.Tbl_Product.Where(a=>a.MaterialPro=="جدیدترین").OrderByDescending (a => a.Id).ToList();

            
            return View();
        }
        public IActionResult shegeft( )
        {
            ViewBag.list = ShowList();
                     ViewBag.shegeft=db.Tbl_Product.Where(a=>a.MaterialPro=="پیشنهادشگفت انگیز").OrderByDescending (a => a.Id).ToList();

            
            return View();
        }
        public IActionResult pishnahad( )
        {
            ViewBag.list = ShowList();
                    ViewBag.pishnahad=db.Tbl_Product.Where(a=>a.MaterialPro=="پیشنهادما").OrderByDescending (a => a.Id).ToList();

            
            return View();
        }
        public IActionResult lahzeh()
        {
            ViewBag.list = ShowList();
            ViewBag.lahzeh=db.Tbl_Product.Where(a=>a.MaterialPro=="پیشنهادلحظه ای").OrderByDescending (a => a.Id).ToList();

            return View();
        }
        
    }
}