using MvcOld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOld.Controllers
{
    public class ProductsController : Controller
    {
        public static List<Product> products = new List<Product>();
        // GET: Products
        [LogFilter]
        [Route("/getall")]
        [HttpGet]
        public ActionResult GetAllProducts()
        {
            if(products.Count == 0)
            {
                products.Add(new Product()
                {
                    Cost = 50000,
                    ItemCode = 1,
                    Name = "Iphone"
                });
            }
            return View(products);
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View(new Product());
        }

        
        [HttpPost]
        public ActionResult AddProduct(Product pProdcut)
        {
            products.Add(pProdcut);
            return View("GetAllProducts", products);
        }

        [HttpGet]
        public ActionResult AddAjaxProduct()
        {
            return View(new Product());
        }

        [HttpPost]
        public ActionResult AddAjaxProduct(Product pProdcut)
        {
            products.Add(pProdcut);
            return PartialView("GetAllProducts", products);
        }
        [HttpGet]
        public ActionResult Edit(int code)
        {
            Product found = products.Where(single => single.ItemCode == code).ToList().FirstOrDefault();
            return View(found);
        }

        [HttpPost]

        public ActionResult Edit(Product updatedProduct)
        {
            Product found = products.Where(single => single.ItemCode == updatedProduct.ItemCode).ToList().FirstOrDefault();
            found.Name = updatedProduct.Name;
            found.Cost = updatedProduct.Cost;   
            return View("GetAllProducts",products);
        }

        [HttpGet]
        public ActionResult ShowSomeView()
        {
            return View("SomeView", new Product()
            {
                ItemCode = 101,
                Cost = 2022,
                Name = "Iphone"
            });
        }

    }
}