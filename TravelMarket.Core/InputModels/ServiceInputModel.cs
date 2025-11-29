using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMarket.Core.OutputModel;

namespace TravelMarket.Core.InputModels
{
    public class ServiceInputModel
    {
        [Required(ErrorMessage ="Название обязательно")]
        [StringLength(255, MinimumLength =2, ErrorMessage ="Название минимум 2 символа")]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Img { get; set; }

        public string? Reviews { get; set; }

        [Required(ErrorMessage = "Цена обязательна")]
        [Range(0.01,double.MaxValue, ErrorMessage ="Цена минимум 1 копейка")]
        public decimal Cost { get; set; }

        public int PartnerId { get; set; }

        public ServiceType TypeOfSevice { get; set; }
    }
}
