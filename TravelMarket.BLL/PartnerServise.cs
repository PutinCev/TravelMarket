using Mapster;
using TravelMarket.Core;
using TravelMarket.Core.Dtos;
using TravelMarket.Core.IRepositories;
using TravelMarket.Core.OutputModel;
using TravelMarket.DAL;


namespace TravelMarket.BLL
{
    public class PartnerServise
    {
        private IPartnerRepozitory _partnerRepozitory;
        public PartnerServise(IPartnerRepozitory partnerRepozitory)
        {
            _partnerRepozitory = partnerRepozitory;
        }
        public List<PartnerOutputModel> GetAll()
        {
            var tmp = _partnerRepozitory.GetAll();
            var rezult = tmp.Adapt<List<PartnerOutputModel>>();
            return rezult;
        }

    }
}
