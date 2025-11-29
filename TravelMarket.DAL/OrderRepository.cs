using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMarket.Core.Dtos;
using TravelMarket.Core;
using TravelMarket.Core.IRepositories;

namespace TravelMarket.DAL
{
    public class OrderRepository:IOrderRepozitory
    {

        private DataContext _dataContext;
        public OrderRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public OrderDto Add(OrderDto order)
        {
            _dataContext.Orders.Add(order);
            _dataContext.SaveChanges();
            return order;
        }
    }
}
