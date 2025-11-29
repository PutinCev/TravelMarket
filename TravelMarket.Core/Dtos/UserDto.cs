using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMarket.Core.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        
        public UserRole? Role { get; set; }

        public string? Login { get; set; }

        public string? Password { get; set; }

        public PartnerDto? Partner { get; set; }

        public List<OrderDto>? Orders { get; set; } = new List<OrderDto>();
    }
}
