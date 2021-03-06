﻿using SportsStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int pageSize = 4;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(int page = 1) => View(repository
                                                .Products.OrderBy(p => p.ProductID)
                                                .Skip((page -1) * pageSize)
                                                .Take(pageSize));
    }
}
