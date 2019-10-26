using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Data.Entities;

namespace WebApplication.Data
{
    public class DataSeeder
    {
        private readonly DataContext _ctx;
        private readonly IWebHostEnvironment _hosting;

        public DataSeeder(DataContext ctx, IWebHostEnvironment hosting)
        {
            _ctx = ctx;
            _hosting = hosting;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();

            if (!_ctx.Makers.Any()) // Should be some makers
            {
                //Create sample data
               var filePath = Path.Combine(_hosting.ContentRootPath, "Data/maker.json");
               var makerJson = File.ReadAllText(filePath);

               var makers = JsonConvert.DeserializeObject<IEnumerable<Maker>>(makerJson);

                _ctx.Makers.AddRange(makers);

                _ctx.SaveChanges();

                filePath = Path.Combine(_hosting.ContentRootPath, "Data/model.json");
                var modelJson = File.ReadAllText(filePath);

                var models = JsonConvert.DeserializeObject<IEnumerable<Model>>(modelJson);

                foreach (var model in models)
                {
                    var manu = _ctx.Makers.Where(m => m.MakerId == model.Maker.MakerId).FirstOrDefault();
                    model.Maker = (Maker)manu;
                    _ctx.Models.Add(model);
                }

                //_context.Models.AddRange(models);

                _ctx.SaveChanges();

            }
        }
    }
}
