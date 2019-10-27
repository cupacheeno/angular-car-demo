using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Data.Entities;

namespace WebApplication.Data
{
    public interface IDataRepository
    {
        IEnumerable<Car> GetAllCars();
        IEnumerable<Motorbike> GetAllMotorbikes();
        IEnumerable<Maker> GetAllMakers();
        IEnumerable<Model> GetAllModels();
        IEnumerable<Model> GetModelsByMaker(Guid makerId);
        IEnumerable<VehicleType> GetAllTypes();
        Maker GetMakerById(Guid makerId);
        Model GetModelById(Guid modelId);
        bool SaveAll();
        void AddEntity(object model);
    }
}
