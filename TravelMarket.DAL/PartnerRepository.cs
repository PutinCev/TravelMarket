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
    public class PartnerRepository : IPartnerRepozitory
    {
        private DataContext _dataContext;

        public PartnerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<PartnerDto> GetAll()
        {
            var rezult = _dataContext.Partners.OrderBy(s => s.Name).ToList();
            return rezult;
        }

        public PartnerDto GetById(int id)
        {
            var rezult = _dataContext.Partners.FirstOrDefault(p => p.Id == id);
            return rezult;
        }
    }
}
