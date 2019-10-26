using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.ViewModels
{
    public class CarViewModel : VehicleViewModel
    {
        [Required]
        public string BodyType { get; set; }
    }
}
