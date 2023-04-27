﻿using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace ProjectOOP.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var values = productManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            ProductValidation validationRules = new ProductValidation();
            ValidationResult results = validationRules.Validate(p);
            if (results.IsValid)
            {
                productManager.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
                return View();
        }
        public IActionResult DeleteProduct(int id) 
        {
            var value = productManager.TGetById(id);
            productManager.TDelete(value);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id) 
        {
            var value = productManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product p) 
        {
            productManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
