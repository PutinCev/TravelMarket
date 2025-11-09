using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMarket.Core.Dtos;

namespace TravelMarket.Core.OutputModel
{
    public class OrderOutputModel
    {
        public int Id { get; set; }
        public DateTime? DateTime { get; set; }
        public UserOutputModel Client { get; set; }
        public ServiceOutputModel Service { get; set; }
        public decimal ServiceCost { get; set; }

    }
}
