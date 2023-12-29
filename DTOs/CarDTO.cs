using WebApplication2_Cars.DataLayer.Models;

namespace WebApplication2_Cars.DTOs
{
    public class CarDTO
    {
        //public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Generation { get; set; }
        public string Color { get; set; }


        public CarDTO(Car model)
        {
            //Id = model.Id;
            Manufacturer = model.Manufacturer;
            Generation = model.Generation;
            Color = model.Color;
        }

        public CarDTO()
        {
        }

        public Car ToModel()
        {
            return new Car() { Color = Color, Generation = Generation, Manufacturer = Manufacturer };
        }
    }
}
