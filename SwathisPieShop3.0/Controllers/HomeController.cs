using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwathisPieShop3._0.Models;
using SwathisPieShop3._0.ViewModels;

namespace SwathisPieShop3._0.Controllers
{
    public class HomeController:Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public ViewResult Index()
        {

            var homeviewmodel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOftheWeek
            };

            return View(homeviewmodel);
        }



    }
}
