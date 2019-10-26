using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Data.Entities
{
    public class Car : Vehicle
    {
        public string BodyType { get; set; }
        public int Doors { get; set; }
        public int Wheels { get; set; }
    }
}
