using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShowRoomAspNet.Models;
using ShowRoomAspNet.Services;

namespace ShowRoomAspNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private IcarService carService;

        public CarService service { get; set; }

        public CarController (IcarService Service)
        {
            this.carService = Service;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok(carService.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromHeader] int id) 
        {
            return Ok(carService.GetById(id));

        }
        [HttpPut]
        public IActionResult Update (int id, [FromBody] Car car) 
        {
            return Ok(carService.UpdateCar(id, car ));
        } 
        [HttpDelete]
        public IActionResult Delete ([FromHeader] int id) 
        {
            return Ok(carService.DeleteCar(id));
        } 
        
        [HttpPost]
        public IActionResult Post([FromBody] Car car) 
        {
            return Ok(carService.AddCar(car));
        }
        
    }
}
