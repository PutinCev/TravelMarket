using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMarket.Core.Dtos
{
    public class ServiceDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Img { get; set; }

        public string? Reviews { get; set; }

        public decimal? Cost { get; set; }

        public PartnerDto? Partner { get; set; }

        public ServiceType? TypeOfSevice { get; set; }

        public List<OrderDto>? Orders { get; set; } = new List<OrderDto>();
    }
}
