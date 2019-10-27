using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;

namespace WebApplication.Controllers
{
    [Route("api/[Controller]")]
    public class MakeController : Controller
    {
        private readonly IDataRepository _repository;
        private readonly ILogger<MakeController> _logger;

        public MakeController(IDataRepository repository, ILogger<MakeController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repository.GetAllMakers());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get makes : {ex}");
                return BadRequest("Failed to get makes");
            }
        }
    }
}
