using Mapster;
using TravelMarket.Core;
using TravelMarket.Core.OutputModel;
using TravelMarket.DAL;

namespace ForDebag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataContext data = new DataContext();
            data.Database.EnsureCreated();

            ServiceRepository repository = new ServiceRepository(data);
            var a=repository.GetAll();  

            var b = a.Adapt<List<ServiceOutputModel>>();

        }
    }
}
