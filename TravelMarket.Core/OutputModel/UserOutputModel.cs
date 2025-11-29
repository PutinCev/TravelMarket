using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMarket.Core.Dtos;

namespace TravelMarket.Core.OutputModel
{
    public class UserOutputModel
    {
        public int Id { get; set; }

        public UserRole Role { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public PartnerOutputModel Partner { get; set; }
        //public List<OrderOutputModel> Orders { get; set; } = new List<OrderOutputModel>();
    }
}
