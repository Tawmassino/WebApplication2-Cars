using WebApplication2_Cars.DataLayer.Models;

namespace WebApplication2_Cars.DTOs
{
    public class GetAllCarsDto
    {
        public GetAllCarsDto(Car model)
        {
            Id = model.Id;
            Manufacturer = model.Manufacturer;
            Generation = model.Generation;
            Color = model.Color;
        }

        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Generation { get; set; }
        public string Color { get; set; }
    }
}
