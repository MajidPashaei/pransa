using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pransa.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;

namespace pransa.Areas.Admin.Controllers
{
    [Area("Admin")]
    // [Authorize]
    // [RolAuthorize]
    public class BaseController : Controller
    {
        public readonly ContextHampadco db;
         public readonly IWebHostEnvironment  _env;
        public static string ln="fa",eror,suc,err = null, NewFileName,prname,NewFileName1,err1;
        
        
        public BaseController( ContextHampadco _db,IWebHostEnvironment  env)
        {
            
             db = _db;
             _env=env;

        }
       

    }
}