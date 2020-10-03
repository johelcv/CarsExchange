using System.Collections.Generic;
using CarsExchange.Models;

namespace CarsExchange.Data
{
    public class MockCarsExchangeRepo : ICarsExchangeRepo
    {
        public IEnumerable<Car> GetAllCars()
        {
            var cars = new List<Car>
            {
                new Car{Id=0,make="Nissan",model="GT-R",year=2019},
                new Car{Id=1,make="Audi",model="Spyder",year=2018},
                new Car{Id=2,make="Ford",model="Mustang",year=2015},
                new Car{Id=3,make="Ferrari",model="Portofino",year=2020},
                new Car{Id=4,make="Aston Martin",model="DBS Superleggera",year=2017},
                new Car{Id=5,make="Jaguar",model="XKSS",year=1960}
            };

            return cars;
        }
    }
}