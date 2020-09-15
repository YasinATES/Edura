using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edura.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private IUnitOfWork uow;
        public CategoryController(IUnitOfWork _uow)
        {
            uow = _uow;
        }


        public IActionResult Index()
        {
            return View(uow.Categories.GetByName("Electronics"));
        }
    }
}
