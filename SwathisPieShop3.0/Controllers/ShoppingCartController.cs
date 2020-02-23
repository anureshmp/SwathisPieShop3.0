using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwathisPieShop3._0.Models;
using SwathisPieShop3._0.ViewModels;

namespace SwathisPieShop3._0.Controllers
{
    public class ShoppingCartController:Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPieRepository pieRepository, ShoppingCart shoppingCart)
        {
            _pieRepository = pieRepository;
            _shoppingCart = shoppingCart;

        }

        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

           return View(shoppingCartViewModel);
        }



    }
}
