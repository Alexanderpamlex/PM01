using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM01
{
    internal class Garage 
    {

        private List<Car> cars = new List<Car>();
        
        public Garage()
        {
                        
        }

        public Garage(Car car)
        {
            cars.Add(car);
        }

        public Garage(Car[] cars)
        {
            this.cars = cars.ToList();
        }

        public Garage(List<Car> cars)
        {
            this.cars = cars;
        }

        public void addCar(Car car) 
        {
            cars.Add(car);        
        }

        public void changeCar(Car car)
        {
            if (cars.FirstOrDefault(x => x.MaxSpeed < car.MaxSpeed) != null)
            {
                var oldCar = new Car();

                int n = cars.First().MaxSpeed;

                foreach (var item in cars)
                {
                    if (n >= item.MaxSpeed)
                    {
                        n = item.MaxSpeed;
                        oldCar = item;
                    }
                }

                cars.Insert(cars.IndexOf(oldCar),car);
                cars.Remove(oldCar);
                
                
            }
            else
                Console.WriteLine("В гараже машины лучше");
        }

        public void getAll() 
        {
            foreach (var item in cars)
            {
                Console.WriteLine($"Car {cars.IndexOf(item)+1}| "+item.ToString());
            }
            Console.WriteLine();
        }

        public void cleanCar(Car car) 
        {
            if (cars.FirstOrDefault(x => x == car) != null)
                if (!car.IsClean)
                {
                    car.IsClean = true;
                    Console.WriteLine("Машмна очищена");
                }
                else
                    Console.WriteLine("Эта машина и так чистая");

            else
                Console.WriteLine("Этой машины нет в гараже");
        }

        public void OrderBySpeed() 
        {
            Console.WriteLine("Сортировка по скорости");
            var res = cars.OrderBy(x => x.MaxSpeed).Reverse();
            foreach (var item in res)
            {
                Console.WriteLine($"Car {cars.IndexOf(item) + 1}| " + item.ToString());
            }
            Console.WriteLine();

        }

        public void OrderByFuel() 
        {
            Console.WriteLine("Сортировка по топливу");
            var res = cars.OrderBy(x => x.FuelPercent).Reverse();
            foreach (var item in res)
            {
                Console.WriteLine($"Car {cars.IndexOf(item) + 1}| " + item.ToString());
            }
            Console.WriteLine();
        }
    }
}
