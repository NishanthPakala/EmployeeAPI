using EmployeeBusinessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployeeService _employeeService;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            _employeeService = employeeService;
        }

        [HttpGet]

        public IEnumerable<EmployeeModel> Get()
        {
            return _employeeService.GetAllEmplyees();
        }
        [HttpGet]
        [Route("getemployees")]
        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return _employeeService.GetAllEmplyees();
        }
        [HttpGet]
        [Route("getmanagers")]
        public IEnumerable<EmployeeModel> GetManagers()
        {

            return _employeeService.GetAllMangers();
        }
        [HttpGet]
        [Route("getdevelopers")]
        public IEnumerable<EmployeeModel> GetDevelopers()
        {
            return _employeeService.GetAllNonMangers();
        }

        [HttpPost]
        public EmployeeModel Post(EmployeeModel employeeModel)
        {
            return _employeeService.AddEmployee(employeeModel);
        }
        [HttpPut]

        public EmployeeModel Put(int Id, EmployeeModel employeeModel)
        {
            return _employeeService.EditEmployee(Id, employeeModel);
        }

    }
}
