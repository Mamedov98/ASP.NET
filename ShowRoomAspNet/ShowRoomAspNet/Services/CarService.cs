using Microsoft.AspNetCore.Mvc;
using ShowRoomAspNet.Models;

namespace ShowRoomAspNet.Services
{
    public class CarService : IcarService
    {
        List<Car> cars = new List<Car>
        {
            new Car{Id = 1,Name = "Bmw", Model = "M5", Year = 2020},
            new Car{Id = 2,Name = "Audi", Model = "A6", Year = 2019},
            new Car{Id = 3,Name = "Mercedes", Model = "E500", Year = 2015},
            new Car{Id = 4,Name = "Porcshe", Model = "911", Year = 2021},
            new Car{Id = 5,Name = "Bmw", Model = "M3", Year = 2022},
        };
        [HttpPost]
        public List<Car> AddCar(Car car)
        {
            cars.Add(car);
            return cars;
        }

        public List<Car> DeleteCar(int id)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Id == id)
                {
                    cars.RemoveAt(i);
                    

                }

            }
            return cars;
        }
        [HttpGet]
        public List<Car> GetAll()
        {
            return cars;
        }

        [HttpGet] 
        public Car GetById([FromHeader]int id)
        {
          
            for (int i = 0; i < cars.Count; i++) 
            {
                if (cars[i].Id == id)
                {
                    return cars[i];

                }
               
            }
            return null; 

        }
        [HttpPut]
        public List<Car> UpdateCar(int id, [FromBody] Car car)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Id == id )
                {
                    cars.RemoveAt(i);
                    cars.Insert(i, car);
                    break;

                }

            }
            return cars;
            
        }
    }
}
