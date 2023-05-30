using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    class Car
    {
        public string Name { get; }
        public string Manufacturer { get; }
        public int Year { get; }

        public Car(string name, string manufacturer, int year)
        {
            Name = name;
            Manufacturer = manufacturer;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Manufacturer} {Name} ({Year})";
        }
    }

    class CarEqualityComparer : IEqualityComparer<Car>
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
    internal class cs4
    {
        public static void task_4()
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Створення масивів автомобілів
            Car[] array1 = {
                new Car("Audi A4", "Audi", 2018),
                new Car("BMW X5", "BMW", 2020),
                new Car("Mercedes-Benz C-Class", "Mercedes", 2019)
            };

            Car[] array2 =
            {
                new Car("Toyota Camry", "Toyota", 2017),
                new Car("BMW X5", "BMW", 2020),
                new Car("Honda Civic", "Honda", 2021)
            };

            Console.WriteLine("---------Task 4---------");

            //Виведення першого масиву з автомобілями
            Console.WriteLine("Car array 1:");
            foreach (Car car in array1)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            //Виведення другого масиву з автомобілями
            Console.WriteLine("Car array 2:");
            foreach (Car car in array2)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();

            // Різниця масивів за виробником
            var difference = array1.Except(array2, new CarEqualityComparer());
            Console.WriteLine("Різниця масивів за виробником:");
            foreach (var car in difference)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            // Перетин масивів за виробником
            var intersection = array1.Intersect(array2, new CarEqualityComparer());
            Console.WriteLine("Перетин масивів за виробником:");
            foreach (var car in intersection)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            // Об'єднання масивів за виробником
            var union = array1.Union(array2, new CarEqualityComparer());
            Console.WriteLine("Об'єднання масивів за виробником:");
            foreach (var car in union)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();

        }

    }
}
