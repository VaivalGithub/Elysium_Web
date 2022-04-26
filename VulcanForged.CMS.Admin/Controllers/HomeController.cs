using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VulcanForged.CMS.Admin.Models;

namespace VulcanForged.CMS.Admin.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IConfiguration _Configuration;


        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment env, IConfiguration configuration)
        {
            _logger = logger;
            _hostingEnvironment = env;
            _Configuration = configuration;

        }

        public IActionResult Index()
        {
            string userId = HttpContext.Session.GetString("SwapBlock_UserID");
            string userName = HttpContext.Session.GetString("SwapBlock_UserName");
            ViewBag.UserName = userName;
            ViewBag.UserId = userId;
            return View();
        }
        [HttpGet]
        public IActionResult Page(string filePath)
        {
            string razorView = System.IO.File.ReadAllText(filePath);
            ViewBag.Page = razorView;
            ViewBag.Filepath = filePath;
            return View("Privacy");
        }

        [HttpPost]
        public JsonResult SavePage(string fileContent, string filePath)
        {
            try
            {
                System.IO.File.WriteAllText(filePath, fileContent);
                return Json("SuccessFully Edit the Page");
            }
            catch (Exception ex)
            {
                return Json("There is some error at the backend");
               
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ShowImages()
        {
            ViewBag.BaseUrl = $"{ (object)Request.Scheme}://{ (object)Request.Host.Value}";
            return View("Images");
        }

        [HttpPost]
        public ActionResult UploadFiles()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var file = HttpContext.Request.Form.Files;

                    if (file.Count > 0)
                    {
                        //var path= @"D:/Projects/Elysium_Web/Elysium.Web/wwwroot/images/";
                        var path = _Configuration["Paths:IMAGES_PATH2"];
                        //var path = $@"{Directory.GetParent("~").Parent.FullName}\VulcanForged.WEB\wwwroot\assets\images\";
                        using (var fileStream = new FileStream(path + file[0].FileName, FileMode.Create))
                        {
                             file[0].CopyTo(fileStream);
                          
                        }

                    }
                    ViewBag.FileStatus = "File uploaded successfully.";
                    return RedirectToAction("ShowImages", "Home");
                }
                catch (Exception ex)
                {

                    ViewBag.FileStatus = "Error while file uploading.";
                }

            }
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
