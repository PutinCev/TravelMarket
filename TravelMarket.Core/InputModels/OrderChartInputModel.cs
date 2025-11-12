using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMarket.Core.Dtos;

namespace TravelMarket.Core.InputModels
{
    public class OrderChartInputModel
    {
        //[Required(ErrorMessage ="Заполнение паспортных данных для заказа путевки обязательно")]
        //public string Passport { get; set; }

        public List<OrderDto> Orders { get; set; } = new List<OrderDto>();
    }
}
