﻿using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;
using System.Linq;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize { get; set; } = 4;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        /// <summary>
        /// This method demonstrate how to do pagination
        /// </summary>
        /// <param name="productPage"></param>
        /// <returns></returns>
        // GET
        public IActionResult Index(string category, int productPage = 1)
        {
            var products = repository.Products
                .Where(p => category == null || p.Category == category)
                .OrderBy(o => o.ProductId)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize);

            var pagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                //TotalItems = repository.Products.Count()
                TotalItems = category == null ? repository.Products.Count() : repository.Products.Where(e => e.Category == category).Count()
            };
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = products,
                PagingInfo = pagingInfo
            };
            return View(model);
        }
    }
}