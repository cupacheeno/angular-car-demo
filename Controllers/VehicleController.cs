using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Data;

namespace WebApplication.Controllers
{
    [Route("api/[Controller]")]
    public class VehicleController : Controller
    {
        private readonly IDataRepository _repository;
        private readonly ILogger<VehicleController> _logger;

        public VehicleController(IDataRepository repository, ILogger<VehicleController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repository.GetAllTypes());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get types : {ex}");
                return BadRequest("Failed to get types");
            }
        }
    }
}
