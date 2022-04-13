using CORE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SERVICES.UnitOfWork;
using SHARED;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VulcanForged.CMS.Admin.Controllers
{
    public class AccountController : Controller
    {

        private readonly ILogger<AccountController> _Logger;
        private IUOW _UOW;
        private readonly IConfiguration _Configuration;

        public AccountController(ILogger<AccountController> logger, IUOW uow, IConfiguration configuration)
        {
            _Logger = logger;
            _UOW = uow;
            _Configuration = configuration;
        }



        #region LOGIN 

        public IActionResult Login()
        {
            
            return View(new Account());
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Auth(Account account)
        {

            ServiceResponse<Account> response = new ServiceResponse<Account>();
            try
            {
                response = _UOW.Account.AdminAuth(account);
                if (response.Status == 1)
                {
                    HttpContext.Session.SetString("SwapBlock_Admin_AccountID", response.Data.AccountID.ToString());
                    HttpContext.Session.SetString("SwapBlock_UserName", response.Data.UserName.ToString());

                    return  RedirectToAction("Index", "Home");
                }

            }
            catch (Exception E)
            {
                response.Status = 0;
                response.Message = E.Message;
            }
            ViewBag.Message = response.Message;
            return View("Login");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            foreach (var cookie in Request.Cookies.Keys)
            {
                if (cookie == ".AspNetCore.Session")
                    Response.Cookies.Delete(cookie);
            }
            HttpContext.Session.Remove("SwapBlock_Admin_AccountID");
            return RedirectToAction("Login", "Account");
        }

        #endregion

        #region FORGOT PASSWORD

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ForgotPassword(string Email)
        {
            ServiceResponse<bool> Response = new ServiceResponse<bool>();
            try
            {
                //Response = _UOW.Accounts.ForgotPassword(Email);
            }
            catch (Exception E)
            {
                Response.Status = 0;
                Response.Message = E.Message;
            }

            return Json(new { Status = Response.Status, Message = Response.Message });
        }

        #endregion

        #region CHANGE PASSWORD

        public IActionResult ChangePassword()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangePassword(string Email, string OldPasword, string NewPassword)
        {
            ServiceResponse<bool> Response = new ServiceResponse<bool>();
            try
            {
                //Response = _UOW.Accounts.ChangePassword(Email, OldPasword, NewPassword);
            }
            catch (Exception E)
            {
                Response.Status = 0;
                Response.Message = E.Message;
            }

            return Json(new { Status = Response.Status, Message = Response.Message });
        }


        #endregion



    }
}
