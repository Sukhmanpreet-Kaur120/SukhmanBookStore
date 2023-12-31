﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SukhmanBookStore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using SukhmanBooks.Models;
using SukhmanBooks.DataAccess.Repository.IRepository;
using System.Linq;
using System.Threading.Tasks;

namespace SukhmanBookStore.Area.Customer.Controllers
{  
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        /*        public HomeController(ILogger<HomeController> logger)
        */
        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            /*return View();*/
            IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category,CoverType");
            return View(productList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.ViewModels.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
