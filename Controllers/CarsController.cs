using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Data;
using WebApplication.Data.Entities;

namespace WebApplication.Controllers
{
    [Route("api/[Controller]")]
    public class CarsController : Controller
    {
        private readonly IDataRepository _repository;
        private readonly ILogger<CarsController> _logger;

        public CarsController(IDataRepository repository, ILogger<CarsController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repository.GetAllCars());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get cars : {ex}");
                return BadRequest("Failed to get cars");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Car model)
        {
            try
            {
                if(model.Make.MakerId != null)
                {
                    Maker manu = _repository.GetMakerById(model.Make.MakerId);
                    if (manu != null)
                    {
                        model.Make = manu;
                    }
                }
                _repository.AddEntity(model);
                if (_repository.SaveAll())
                {
                    return Created($"/api/cars/{model.Id}", model);
                } else
                {
                    return BadRequest("Failed to create a car");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to create car : {ex}");
                return BadRequest("Failed to create a car");
            }
        }
    }
}
