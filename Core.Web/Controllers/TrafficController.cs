using Core.Application.Implementation;
using Core.Application.Interfaces;
using Core.Data.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Core.Web.Controllers
{
    public class TrafficController : Controller
    {
        private readonly IHttpService _httpService;
        public TrafficController(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public IActionResult Index()
        {
            
            return View();
        }

    }
}
