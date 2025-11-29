using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMarket.Core.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }

        public DateTime? DateTime { get; set; }

        public UserDto? Client { get; set; }

        public ServiceDto? Service { get; set; }
    }
}
