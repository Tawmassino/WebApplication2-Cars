using WebApplication2_Cars.DataLayer.Models;
using WebApplication2_Cars.DataLayer.FakeDatabase;
using System.Drawing;
using WebApplication2_Cars.DTOs;
using Microsoft.Extensions.Logging;

namespace WebApplication2_Cars.DataLayer.Repositories
{
    public interface ICarRepository
    {
        void AddNewCar(Car car);
        void RemoveCar(int id);
        List<Car> GetAll();
        List<Car> GetByColor(string color);
        void UpdateCar(Car car);
    }

    public class CarRepository : ICarRepository
    {
        private readonly List<Car> _carDatabase;
        private readonly ILogger<CarRepository> _logger;

        public CarRepository()
        {
            _carDatabase = new CarsDatabase().GetAll();//pasiimam fake database
        }
        public List<Car> GetAll()
        {
            return _carDatabase;
        }

        public List<Car> GetByColor(string color)
        {
            return _carDatabase.Where(car => car.Color == color).ToList();
        }

        public void AddNewCar(Car car)
        {
            _carDatabase.Add(car);
        }

        public void UpdateCar(Car car)
        {
            var carFromDb = _carDatabase.FirstOrDefault(c => car.Id == c.Id);

            if (carFromDb == null)
            {
                _logger.LogError($"Book with ID {car.Id} was not found in database");
                throw new ArgumentException($"Book with ID {car.Id} was not found in database");
            }

            if (!string.IsNullOrEmpty(car.Generation))
            {
                carFromDb.Generation = car.Generation;
            }
            if (!string.IsNullOrEmpty(car.Manufacturer))
            {
                carFromDb.Manufacturer = car.Manufacturer;
            }
            //_carDatabase.SaveChanges();

        }

        public void RemoveCar(int id)
        {
            var carFromDb = _carDatabase.FirstOrDefault(c => c.Id == c.Id);
            _carDatabase.Remove(carFromDb);
        }
    }
}
