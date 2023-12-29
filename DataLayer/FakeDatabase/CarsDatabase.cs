using WebApplication2_Cars.DataLayer.Models;

namespace WebApplication2_Cars.DataLayer.FakeDatabase
{
    public class CarsDatabase
    {

        List<Car> carList = new List<Car>
        {
            new Car { Id = 1, Manufacturer = "Toyota", Generation = "Camry", Color = "Blue" },
            new Car { Id = 2, Manufacturer = "Ford", Generation = "Mustang", Color = "Red" },
            new Car { Id = 3, Manufacturer = "Honda", Generation = "Civic", Color = "Silver" },
            new Car { Id = 4, Manufacturer = "Chevrolet", Generation = "Malibu", Color = "Black" },
            new Car { Id = 5, Manufacturer = "Nissan", Generation = "Altima", Color = "White" },
            new Car { Id = 6, Manufacturer = "BMW", Generation = "3 Series", Color = "Green" },
            new Car { Id = 7, Manufacturer = "Mercedes-Benz", Generation = "C-Class", Color = "Gray" },
            new Car { Id = 8, Manufacturer = "Audi", Generation = "A4", Color = "Yellow" },
            new Car { Id = 9, Manufacturer = "Hyundai", Generation = "Sonata", Color = "Orange" },
            new Car { Id = 10, Manufacturer = "Kia", Generation = "Optima", Color = "Purple" },
            new Car { Id = 11, Manufacturer = "Mazda", Generation = "Mazda3", Color = "Brown" },
            new Car { Id = 12, Manufacturer = "Subaru", Generation = "Impreza", Color = "Pink" },
            new Car { Id = 13, Manufacturer = "Volkswagen", Generation = "Jetta", Color = "Cyan" },
            new Car { Id = 14, Manufacturer = "Lexus", Generation = "ES", Color = "Magenta" },
            new Car { Id = 15, Manufacturer = "Chrysler", Generation = "300", Color = "Gold" },
            new Car { Id = 16, Manufacturer = "Toyota", Generation = "Good", Color = "Blue" },
        };

        public List<Car> GetAll()
        {
            return carList;
        }
    }
}
