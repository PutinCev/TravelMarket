using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using TravelMarket.Core.Dtos;
using TravelMarket.Core.InputModels;
using TravelMarket.Core.IRepositories;

namespace TravelMarket.BLL
{
    public class OrderService
    {
        private IOrderRepozitory _orderRepozitory;
        private IServiceRepozitory _serviceRepozitory;

        public OrderService(IOrderRepozitory orderRepozitory, IServiceRepozitory serviceRepozitory)
        {
            _orderRepozitory = orderRepozitory;
            _serviceRepozitory = serviceRepozitory;
        }

        public bool Add(List<OrderInputModel> orders)
        {
            var ids = orders.Select(o => o.ServiceId).ToList();

            var serviceDtos = _serviceRepozitory.GetAllByIds(ids);


            foreach (var serviceDto in serviceDtos)
            {
                var newOrderDto = new OrderDto();
                newOrderDto.Service = serviceDto;
                _orderRepozitory.Add(newOrderDto);   
            }
            return true;    
        }

    }
}
