using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Data.Entities;

namespace WebApplication.Data
{
    public class DataRepository : IDataRepository
    {
        private readonly DataContext _ctx;
        private readonly ILogger _logger;

        public DataRepository(DataContext ctx, ILogger<DataRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }
        public void AddEntity(object model)
        {
            _ctx.Add(model);
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _ctx.Cars
                .Include(mak => mak.Make)
                .Include(mod => mod.Model)
                .ToList();
        }

        public IEnumerable<Maker> GetAllMakers()
        {
            return _ctx.Makers.ToList();
        }

        public IEnumerable<Model> GetAllModels()
        {
            return _ctx.Models.ToList();
        }

        public IEnumerable<Motorbike> GetAllMotorbikes()
        {
            return _ctx.Motorbikes
                .Include(mak => mak.Make)
                .Include(mod => mod.Model)
                .ToList();
        }

        public Maker GetMakerById(Guid makerId)
        {
            return _ctx.Makers.Where(manu => manu.MakerId == makerId).FirstOrDefault();
        }

        public Model GetModelById(Guid modelId)
        {
            return _ctx.Models.Where(mod => mod.ModelId == modelId).Include(mod => mod.Maker).FirstOrDefault();
        }

        public IEnumerable<Model> GetModelsByMaker(Guid makerId)
        {
            return _ctx.Models.Where(mod => mod.Maker.MakerId == makerId).ToList();
        }

        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }
    }
}
