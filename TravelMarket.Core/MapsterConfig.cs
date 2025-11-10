using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using TravelMarket.Core.Dtos;
using TravelMarket.Core.InputModels;
using TravelMarket.Core.OutputModel;

namespace TravelMarket.Core
{
    public class MapsterConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.Default.PreserveReference(true);
            config.NewConfig<OrderDto, OrderOutputModel>();
            config.NewConfig<PartnerDto, PartnerOutputModel>();
            config.NewConfig<UserDto, UserOutputModel>();
            config.NewConfig<ServiceDto, ServiceOutputModel>() 
            .Map(p => p.Name, dto => dto.Name!.ToUpper());

            config.NewConfig<OrderInputModel, OrderDto>();


        }
    }
}
