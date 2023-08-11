using Microsoft.AspNetCore.Mvc;

using eWellness.BL.Common;
using eWellness.Core.Models;
using eWellness.BL;
using eWellness.Core.Parameters;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eWellness.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        IEmployeeService _employeeService { get; set; }
        IActivityLogService _activityLogger { get; set; }

        public EmployeesController(IEmployeeService employeeService, IActivityLogService activityLogger)
        {
            _employeeService = employeeService;
            _activityLogger = activityLogger;
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                if(id == 0)
                {
                    throw (new Exception("Id not provided"));
                }
                return Ok(await _employeeService.GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Get),
                    Controller = nameof(EmployeesController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error", 
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }

        // GET api/<EmployeesController>/all
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var filter = new BaseFilterParameters() { PageNumber = 1, PageSize = int.MaxValue };
            try
            {
                return Ok(await _employeeService.FilterAsync(filter));
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Get),
                    Controller = nameof(EmployeesController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error",
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Employee model)
        {
            try
            {
                await _employeeService.AddAsync(model);
                return Ok();
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Post),
                    Controller = nameof(EmployeesController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error",
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Employee model)
        {
            try
            {
                if (id == 0)
                {
                    throw (new Exception("Id not provided"));
                }

                model.Id = id;
                _employeeService.Update(model);
                return Ok();
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Put),
                    Controller = nameof(EmployeesController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error",
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw (new Exception("Id not provided"));
                }
                var employee = await _employeeService.GetByIdAsync(id);
                if (employee == null)
                {
                    throw (new Exception("Employee not found"));
                }
                _employeeService.Remove(employee);

                return Ok();
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Delete),
                    Controller = nameof(EmployeesController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error",
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }
    }
}
