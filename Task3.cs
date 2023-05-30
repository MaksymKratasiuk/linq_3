using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_3
{

    class Car
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
    }

    class Task3
    {
        public static void task3()
        {
            Car[] array1 = {
                new Car { Name = "Model 3", Manufacturer = "Tesla", Year = 2020 },
                new Car { Name = "Civic", Manufacturer = "Honda", Year = 2019 },
                new Car { Name = "Mustang", Manufacturer = "Ford", Year = 2021 }
            };

            Car[] array2 = {
                new Car { Name = "Accord", Manufacturer = "Honda", Year = 2020 },
                new Car { Name = "Model S", Manufacturer = "Tesla", Year = 2021 },
                new Car { Name = "Camry", Manufacturer = "Toyota", Year = 2022 }
            };

            // Різниця між масивами за виробником
            var difference = array1.Except(array2, new CarManufacturerComparer());
            Console.WriteLine("Різниця між масивами:");
            foreach (var car in difference)
            {
                Console.WriteLine($"{car.Name} - {car.Manufacturer}");
            }

            Console.WriteLine();

            // Перетин масивів за виробником
            var intersection = array1.Intersect(array2, new CarManufacturerComparer());
            Console.WriteLine("Перетин масивів:");
            foreach (var car in intersection)
            {
                Console.WriteLine($"{car.Name} - {car.Manufacturer}");
            }

            Console.WriteLine();

            // Об'єднання масивів за виробником
            var union = array1.Union(array2, new CarManufacturerComparer());
            Console.WriteLine("Об'єднання масивів:");
            foreach (var car in union)
            {
                Console.WriteLine($"{car.Name} - {car.Manufacturer}");
            }
        }
    }

    class CarManufacturerComparer : IEqualityComparer<Car>
    {
        public bool Equals(Car x, Car y)
        {
            return x.Manufacturer == y.Manufacturer;
        }

        public int GetHashCode(Car obj)
        {
            return obj.Manufacturer.GetHashCode();
        }
    }
    
}
