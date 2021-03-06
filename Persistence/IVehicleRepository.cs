using System.Threading.Tasks;
using aspdotnetblog.Models;

namespace aspdotnetblog.Persistence
{

    public interface IVehicleRepository
    {
         Task<Vehicle> GetVehicle(int id, bool includeRelated = true);
          void Add(Vehicle vehicle);
          void Remove(Vehicle vehicle);
    }
}