using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwathisPieShop3._0.Models;
using SwathisPieShop3._0.ViewModels;

namespace SwathisPieShop3._0.Controllers
{
    public class OrderController:Controller
    {
        private readonly IOrderRepository _orderrepository;
        private readonly ShoppingCart _shoppingcart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderrepository = orderRepository;
            _shoppingcart = shoppingCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingcart.GetShoppingCartItems();
            _shoppingcart.ShoppingCartItems = items;

            if(_shoppingcart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty! add some pies first");
            }

            if(ModelState.IsValid)
            {
                _orderrepository.CreateOrder(order);
                _shoppingcart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);

        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your order! You will soon enjoy your pies";

            return View();

        }

    }
}
