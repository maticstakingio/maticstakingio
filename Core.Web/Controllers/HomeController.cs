using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core.Models;
using Core.Application.Interfaces;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.Drawing;
using System.IO;
using Core.Application.ViewModels.Export;
using Core.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAirdropService _airdropService;
        private readonly IBlockChainService _blockChainService;
        private readonly UserManager<AppUser> _userManager;
        public HomeController(
            IAirdropService airdropService,
            IBlockChainService blockChainService,
            UserManager<AppUser> userManager
            )
        {
            _userManager = userManager; 
            _blockChainService = blockChainService;
            _airdropService = airdropService;
        }

        public async Task<string> Testing()
        { 
            var gasPrice = await _blockChainService.GetGasPrice();

            return "";
        }


        public IActionResult Index(string refCode="")
        { 
            ViewBag.RefCode = refCode;   
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }


    }
}
