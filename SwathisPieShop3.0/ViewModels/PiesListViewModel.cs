using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwathisPieShop3._0.Models;

namespace SwathisPieShop3._0.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }

    }
}
