using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using TravelMarket.Core;
using TravelMarket.Core.OutputModel;
using TravelMarket.BLL;

namespace TravelMarket.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceController : ControllerBase
    {
        private ServServise _servServise;

        public ServiceController(ServServise servServise)
        {
            _servServise = servServise;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <response code="200">мок модельки услуг</response>

        [HttpGet("all", Name = "Получить все услуги")]
        public ActionResult<IEnumerable<ServiceOutputModel>> GetAll()
        {
            var rezult = _servServise.GetAll();
            return Ok(rezult);
        }

        [HttpGet("{id}")]
        public ActionResult<ServiceOutputModel> GetById(int id)
        {
            try
            {
                var rezult = GetServiceById(id);
                return Ok(rezult);
            }
            catch(InvalidOperationException)
            {
                return NotFound();
            }        
        }

        private ServiceOutputModel GetServiceById(int id)
        {
            var rezultAll = _servServise.GetAll();
            var rezult = rezultAll.Single(s => s.Id == id);

            return rezult;
        }

        /// <summary>
        /// Вернет услугу
        /// </summary>
        /// <returns></returns>
        /// <response code="200">мок моделька услуги</response>

        [HttpGet(Name = "Service")]
        public ServiceOutputModel Get()
        {
            return new ServiceOutputModel()
            {
                Id = 1,
                Name = "Интересное путешествие",
                Cost = 5000,
                TypeOfSevice = ServiceType.BusTrip
            };
        }
    }
}
