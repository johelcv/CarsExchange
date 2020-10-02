using System.Collections.Generic;
using CarsExchange.Models;

namespace CarsExchange.Data
{
    public interface ICarsExchangeRepo
    {
        IEnumerable<Car> GetAllCars();
    }
}