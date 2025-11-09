using System.Net.Http.Headers;
using Mapster;
using TravelMarket.Core;
using TravelMarket.Core.Dtos;
using TravelMarket.Core.InputModels;
using TravelMarket.Core.IRepositories;
using TravelMarket.Core.OutputModel;
using TravelMarket.DAL;

namespace TravelMarket.BLL
{
    public class ServServise
    {
        private IServiceRepozitory _serviceRepozitory;
        private IPartnerRepozitory _partnerRepozitory;

        public ServServise(IServiceRepozitory serviceRepozitory, IPartnerRepozitory partnerRepozitory)
        {
            _serviceRepozitory = serviceRepozitory;
            _partnerRepozitory = partnerRepozitory;

        }

        public List<ServiceOutputModel> GetAll()
        {
            var tmp = _serviceRepozitory.GetAll();
            var result = tmp.Adapt<List<ServiceOutputModel>>();
            return result;
        }
        public ServiceOutputModel Add(ServiceInputModel service)
        {
            ServiceDto servDto = service.Adapt<ServiceDto>();
            servDto.Partner = _partnerRepozitory.GetById(service.PartnerId);
            var tmp = _serviceRepozitory.Add(servDto);
            var result = tmp.Adapt<ServiceOutputModel>();
            return result;
        }
    }
}
