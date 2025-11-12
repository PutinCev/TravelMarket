using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMarket.Core.Dtos;

namespace TravelMarket.Core.IRepositories
{
    public interface IOrderRepozitory
    {
        public OrderDto Add(OrderDto order);

    }
}
