﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpyStore_HOL.DAL.Repos.Interfaces;
using SpyStore_HOL.Models.Entities;
using SpyStore_HOL.Models.ViewModels;
using SpyStore_HOL.MVC.Controllers.Base;

namespace SpyStore_HOL.MVC.Controllers
{
    [Route("[controller]/[action]/{customerId}")]
    public class OrdersController : BaseController
    {
        private readonly IOrderRepo _orderRepo;
        public OrdersController(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index(int customerId)
        {
            ViewBag.Title = "Order History";
            ViewBag.Header = "Order History";
            IList<Order> orders = _orderRepo.GetOrderHistory(customerId).ToList();
            return View(orders);
        }

        [HttpGet("{orderId}")]
        public IActionResult Details(int customerId, int orderId)
        {
            ViewBag.Title = "Order Details";
            ViewBag.Header = "Order Details";
            OrderWithDetailsAndProductInfo orderDetails = _orderRepo.GetOneWithDetails(customerId, orderId);
            if (orderDetails == null) return NotFound();
            return View(orderDetails);
        }
    }
}