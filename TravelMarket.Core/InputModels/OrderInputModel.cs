using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMarket.Core.InputModels
{
    public class OrderInputModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int Number { get; set; }

        public int ServiceId { get; set; }

        public string? ServiceName { get; set; }

        public decimal ServiceCost { get; set; }


    }
}
