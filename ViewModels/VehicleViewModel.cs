using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Data.Entities;

namespace WebApplication.ViewModels
{
    public class VehicleViewModel
    {
        public Guid Id { get; set; }
        [Required]
        public Maker Make { get; set; }
        [Required]
        public Model Model { get; set; }
        public string Engine { get; set; }
        [Required]
        public decimal SalePrice { get; set; }
    }
}
