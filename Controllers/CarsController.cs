using System.Collections.Generic;
using CarsExchange.Data;
using CarsExchange.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarsExchange.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly MockCarsExchangeRepo _repository = new MockCarsExchangeRepo();

        //GET api/cars
        [HttpGet]
        public ActionResult <IEnumerable<Car>> GetAllCars()
        {
            var carList = _repository.GetAllCars();
            return Ok(carList);
        }
    }
}