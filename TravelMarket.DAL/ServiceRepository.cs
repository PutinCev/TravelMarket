using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelMarket.Core;
using TravelMarket.Core.Dtos;
using TravelMarket.Core.IRepositories;
using Microsoft.EntityFrameworkCore;



namespace TravelMarket.DAL
{
    public class ServiceRepository : IServiceRepozitory
    {
        private DataContext _dataContext;
        public ServiceRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public ServiceDto Add(ServiceDto service)
        {
            _dataContext.Services.Add(service); 
            _dataContext.SaveChanges();
            return service;
        }

        public List<ServiceDto> GetAll()
        {
            var rezult = _dataContext.Services.Include(s=>s.Partner).Include(s => s.Orders).OrderBy(s => s.Name).ToList();
            return rezult;
        }
    }
}
