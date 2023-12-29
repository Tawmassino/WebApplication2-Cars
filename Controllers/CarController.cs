using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using WebApplication2_Cars.DataLayer.Models;
using WebApplication2_Cars.DataLayer.Repositories;
using WebApplication2_Cars.DTOs;

namespace WebApplication2_Cars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {

        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public IEnumerable<GetAllCarsDto?> GetAll()
        {
            var data = _carRepository.GetAll();
            return data.Select(t => new GetAllCarsDto(t));//selectina kiekviena CarDTO is masyvo atskirai i IEnum List
        }

        [HttpGet("GetCarsByColor")]
        public IEnumerable<GetAllCarsDto?> GetCarsByColor([FromQuery] string color)
        {
            var data = _carRepository.GetByColor(color);
            return data.Select(CarWithColor => new GetAllCarsDto(CarWithColor));

        }

        [HttpPost]
        public Car AddNewCar(CarDTO car)
        {
            //sukonstruot car is carDto

            Car carReal = car.ToModel();

            //paduot i repo
            _carRepository.AddNewCar(carReal);

            return carReal;
        }


        [HttpPut("updateCarManufacturer")]
        public void UpdateCar(CarMakerDTO carMaker)
        {

            //sukonstruot car is carDto
            Car carReal = carMaker.ToModel();            

            //paduot i repo
            _carRepository.UpdateCar(carReal);
        }


        [HttpDelete("RemoveCarBy{id}")]
        public void RemoveCar(int id)
        {
            _carRepository.RemoveCar(id);
        }
    }
}
