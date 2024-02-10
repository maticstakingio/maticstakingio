﻿using Core.Application.Implementation;
using Core.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Core.Web.Controllers
{

    public class WorkerController : Controller
    {
        private readonly ILogger<WorkerController> _logger;
        public WorkerController(
            ILogger<WorkerController> logger
            )
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
