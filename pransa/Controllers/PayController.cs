using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.AdminEntities.Order;
using DataLayer.Context;
using Dto.Payment;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ZarinPal.Class;
//using pransa.Models;

namespace pransa.Controllers
{
    public class PayController : BaseController
    {
        public static string msg ;
        private readonly Payment _payment; 
        private readonly Authority _authority; 
        private readonly Transactions _transactions;
        public PayController(ContextHampadco _db,IWebHostEnvironment env):base(_db,env)
        {
            var expose = new Expose();
            _payment = expose.CreatePayment();
            _authority = expose.CreateAuthority();
            _transactions = expose.CreateTransactions();
        }

        public IActionResult Index()
        {
            if (msg !=null)
            {
                ViewBag.msg = msg ;
                msg = null ;
            }
            return View();
        }

        public async Task<IActionResult> Request()
        {
            var result = await _payment.Request(new DtoRequest()
            {
                Mobile = "09121112222",
                CallbackUrl = "https://localhost:5001/pay/validate",
                Description = "توضیحات",
                Email = "farazmaan@outlook.com",
                Amount = 1000000,
                MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX"
            }, ZarinPal.Class.Payment.Mode.sandbox);
            return Redirect($"https://sandbox.zarinpal.com/pg/StartPay/{result.Authority}");
        }

        public async Task<IActionResult> Validate(string authority, string status)
        {
            var verification = await _payment.Verification(new DtoVerification
            {
                Amount = 1000000,
                MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                Authority = authority
            }, Payment.Mode.sandbox);

            if (verification.Status == 100)
            {
                Tb_Factor to = new Tb_Factor()
                {
                };

                msg = "success";

                return RedirectToAction("Index"); 
            }
            else
            {
                msg = "error"; 
                return RedirectToAction("Index");   
            }
        }

    }
}