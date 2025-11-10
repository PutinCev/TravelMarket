using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMarket.Core.InputModels;
using TravelMarket.Core.IRepositories;

namespace TravelMarket.BLL
{
    public class OrderService
    {

        private IOrderRepozitory _orderRepozitory;

        public OrderService(IOrderRepozitory orderRepozitory)
        {
            _orderRepozitory = orderRepozitory;

        }

        public bool Add(OrderInputModel order)
        { 
            return true;
        }

    }
}
