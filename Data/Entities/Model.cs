using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Data.Entities
{
    public class Model
    {
        public Guid ModelId { get; set; }
        public string Name { get; set; }
        public Maker Maker { get; set; }
    }
}
