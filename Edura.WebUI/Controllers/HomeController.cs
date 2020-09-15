﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Edura.WebUI.Models;
using Edura.WebUI.Repository.Abstract;
using Edura.WebUI.Entity;

namespace Edura.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWork uow;

        public HomeController(IUnitOfWork _uow)
        {
            uow = _uow;
        }

        public IActionResult Index()
        {
            return View(uow.Products.GetAll().Where(i=>i.IsApproved && i.IsHome).ToList());
        }

        public IActionResult Details(int id)
        {
            return View(uow.Products.Get(id));
        }

        public IActionResult Create()
        {
            var prd = new Product() { ProductName = "Deneme", Price = 1000 };
            uow.Products.Add(prd);
            uow.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
