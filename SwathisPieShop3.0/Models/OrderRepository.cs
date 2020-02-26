using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwathisPieShop3._0.Models
{
    public class OrderRepository : IOrderRepository
    {

        private readonly AppDBContext _appdbcontext;
        private readonly ShoppingCart _shoppingcart;

        public OrderRepository(AppDBContext appDbContext, ShoppingCart shoppingCart)
        {
            _appdbcontext = appDbContext;
            _shoppingcart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _appdbcontext.Orders.Add(order);

            var shoppingCartItems = _shoppingcart.ShoppingCartItems;

            foreach(var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    PieId = shoppingCartItem.Pie.PieId,
                    OrderId = order.OrderId,
                    Price = shoppingCartItem.Pie.Price
                };

                _appdbcontext.OrderDetails.Add(orderDetail);

            }
            _appdbcontext.SaveChanges();
        }
    }
}
