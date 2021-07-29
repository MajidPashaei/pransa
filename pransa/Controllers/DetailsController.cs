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
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pransa.Models;
using DataLayer.Context;
using DataLayer.AdminEntities;
using Kavenegar;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using ViewModels.AdminViewModel.GalleryProduct;

namespace pransa.Controllers
{
    
    public class DetailsController :BaseController
    {
        
           ////////////////////////////////////////////type db
           public DetailsController(ContextHampadco _db,IWebHostEnvironment env):base(_db,env)
        {
            
        }

        public IActionResult index(int Id)
        {
            ViewBag.list = ShowList();
            ViewBag.product=db.Tbl_Product.OrderByDescending(a => a.Id).Take(6).ToList();

            ViewBag.kala=db.Tbl_Product.Where(a=>a.Id==Id).ToList();

            var s = db.tb_GalleryProducts.Where(a => a.IdProduct == Id).ToList();
            List<Vm_GalleryProduct> sd = new List<Vm_GalleryProduct>();
            foreach (var item in s)
            {
                Vm_GalleryProduct q = new Vm_GalleryProduct()
                {
                    Id = item.Id,
                    ImagePath = item.ImagePath,
                    
                };
                sd.Add(q);
            }
            ViewBag.GaleryP = sd;

            return View();
        }
        //addcatr
        public IActionResult addcart(int id)
        {
            //add
            string a=HttpContext.Session.GetString ("shop");

            if ( a != null)
            {
                 HttpContext.Session.SetString ("shop",a+id.ToString()+",");
            }else
            {
                HttpContext.Session.SetString ("shop",id.ToString()+",");
            }
            
            //count
           
            ShowList();

            return RedirectToAction ("index",new{id=id});
        }

        public IActionResult del(int id)
        {

            //  String[] listshop=(HttpContext.Session.GetString("shop")).Split(",");
            //     if (listshop != null)
            //     { 
                  
            //         foreach (var item in listshop)
            //         {
            //             if (item==id.ToString())
            //             {
                            
            //             }else
            //             {
                            
            //             }


            HttpContext.Session.SetString("shop",HttpContext.Session.GetString("shop").Replace(id.ToString()+",",""));
            ShowList();
            
             return RedirectToAction("index",new{id=id});
        }
        
        
    }
}