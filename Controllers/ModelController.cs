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
    public class ModelController : Controller
    {
        private readonly IDataRepository _repository;
        private readonly ILogger<VehicleController> _logger;

        public ModelController(IDataRepository repository, ILogger<VehicleController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repository.GetAllModels());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get models : {ex}");
                return BadRequest("Failed to get models");
            }
        }

        [HttpGet("{id:Guid}")]
        public IActionResult GetAllModelsById(Guid id)
        {
            try
            {
                return Ok(_repository.GetModelsByMaker(id));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get models for maker : {ex}");
                return BadRequest("Failed to get models for maker");
            }
        }
    }
}
