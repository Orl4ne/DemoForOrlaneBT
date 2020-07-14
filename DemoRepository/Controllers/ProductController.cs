using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;

namespace DemoRepository.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository<Product> _repository;

        public ProductController(IProductRepository<Product> repository)
        {            
            _repository = repository;
        }

        public IActionResult Index()
        {
            ViewBag.HashCode = _repository.GetHashCode();
            return View();
        }
    }
}
