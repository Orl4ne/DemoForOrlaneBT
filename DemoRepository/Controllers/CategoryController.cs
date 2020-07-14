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
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository<Category> _repository;

        public CategoryController(ICategoryRepository<Category> repository)
        {
            Debug.WriteLine(repository.GetHashCode());
            _repository = repository;
        }

        public IActionResult Index()
        {
            ViewBag.HashCode = _repository.GetHashCode();
            return View(_repository.Categories);
        }
    }
}
