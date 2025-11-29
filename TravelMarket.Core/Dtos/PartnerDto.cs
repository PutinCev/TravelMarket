using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMarket.Core.Dtos
{
    public class PartnerDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Agreement { get; set; }

        public string? Description { get; set; }

        public string? TransportationVoucher { get; set; }

        public string? Reminder { get; set; }

        public string? AccommodationVoucher { get; set; }

        public string? TermsOfPayment { get; set; }

        public List<UserDto>? Users { get; set; } = new List<UserDto>();

        public List<ServiceDto>? Services { get; set; } = new List<ServiceDto>();

    }
}
