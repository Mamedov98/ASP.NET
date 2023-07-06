using ShowRoomAspNet.Models;

namespace ShowRoomAspNet.Services
{
    public interface IcarService
    {
        List<Car> GetAll();

        Car GetById (int id);

        List<Car> AddCar (Car car);
        List<Car> UpdateCar  (int id,Car car);
        List<Car> DeleteCar  (int id);
    }
}
