using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Data.Entities
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public Maker Make { get; set; }
        public Model Model { get; set; }
        public string Engine { get; set; }
        public decimal SalePrice { get; set; }
    }
}
