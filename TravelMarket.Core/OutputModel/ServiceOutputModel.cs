using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMarket.Core.Dtos;

namespace TravelMarket.Core.OutputModel
{



    public class ServiceOutputModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Img { get; set; }

        public string? Reviews { get; set; }

        public decimal Cost { get; set; }

        public PartnerOutputModel Partner { get; set; }

        public ServiceType TypeOfSevice { get; set; }
        //public List<OrderOutputModel> Orders { get; set; } = new List<OrderOutputModel>();
    }
}
