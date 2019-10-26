using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Data;
using WebApplication.Data.Entities;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    [Route("api/[Controller]")]
    public class CarsController : Controller
    {
        private readonly IDataRepository _repository;
        private readonly ILogger<CarsController> _logger;
        private readonly IMapper _mapper;

        public CarsController(IDataRepository repository, ILogger<CarsController> logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
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
        public IActionResult Post([FromBody]CarViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var newCar = _mapper.Map<CarViewModel, Car>(model);

                    Maker manu = _repository.GetMakerById(newCar.Make.MakerId);
                    if (manu != null)
                    {
                        newCar.Make = manu;
                    }
                    else
                    {
                        return BadRequest($"Make : {newCar.Make.Name} does not exist");
                    }

                    Model mod = _repository.GetModelById(newCar.Model.ModelId);
                    if (mod != null)
                    {
                        newCar.Model = mod;
                    }
                    else
                    {
                        return BadRequest($"Model : {newCar.Model.Name} does not exist");
                    }
                    _repository.AddEntity(newCar);
                    if (_repository.SaveAll())
                    {
                        return Created($"/api/cars/{newCar.Id}", _mapper.Map<Car,CarViewModel>(newCar));
                    }
                    else
                    {
                        return BadRequest("Failed to create a car");
                    }
                } 
                else
                {
                    return BadRequest(ModelState);
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
