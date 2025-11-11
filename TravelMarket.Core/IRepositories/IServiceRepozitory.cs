using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMarket.Core.Dtos;

namespace TravelMarket.Core.IRepositories
{
    public interface IServiceRepozitory
    {
        public List<ServiceDto> GetAll();

        public ServiceDto Add(ServiceDto service);

        public List<ServiceDto> GetAllByIds(List<int> ids);
        public ServiceDto GetAllById(int id);


    }
}
