﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwathisPieShop3._0.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
