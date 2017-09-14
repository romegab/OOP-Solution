using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsRace
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                Car car = new Car(input[0], decimal.Parse(input[1]), decimal.Parse(input[2]));
                cars.Add(input[0], car);

            }
            var inputParams = Console.ReadLine().Split().ToList();

            while (inputParams[0]!="end")
            {
                if (inputParams[0]=="drive")
                {
                    cars[inputParams[1]].Drive(int.Parse(inputParams[2]));
                }   
                inputParams = Console.ReadLine().Split().ToList();
            }
            foreach (var car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelLeft} {car.Distance}");
            }
        }
    }
}
