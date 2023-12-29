using WebApplication2_Cars.DataLayer.Models;

namespace WebApplication2_Cars.DTOs
{
    public class CarMakerDTO
    {

        public int Id { get; set; }
        public string Manufacturer { get; set; }



        public CarMakerDTO(Car model)
        {
            Id = model.Id;
            Manufacturer = model.Manufacturer;

        }

        public CarMakerDTO()
        {
        }

        public Car ToModel()
        {
            return new Car() { Id = Id, Manufacturer = Manufacturer };
        }
    }
}
