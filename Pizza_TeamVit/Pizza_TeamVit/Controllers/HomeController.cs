using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizza_TeamVit.Models;

namespace Pizza_TeamVit.Controllers
{
    public class HomeController : Controller
    {

        private IStoreRepository repository;
        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        public int PageSize = 50; //kích cỡ trang
        public ViewResult Index(int productPage = 1) => View(repository.Products
                    .OrderBy(p => p.ProductId)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize));
    }
}
