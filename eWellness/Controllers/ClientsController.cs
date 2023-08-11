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
    public class ClientsController : ControllerBase
    {
        IClientService _clientService { get; set; }
        IActivityLogService _activityLogger { get; set; }

        public ClientsController(IClientService clientService, IActivityLogService activityLogger)
        {
            _clientService = clientService;
            _activityLogger = activityLogger;
        }

        // GET api/<ClientsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                if(id == 0)
                {
                    throw (new Exception("Id not provided"));
                }
                return Ok(await _clientService.GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Get),
                    Controller = nameof(ClientsController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error", 
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }

        // GET api/<ClientsController>/all
        [HttpGet]
        public async Task<ActionResult> GetAll([FromQuery] BaseFilterParameters filter)
        {
            try
            {
                return Ok(await _clientService.FilterAsync(filter));
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Get),
                    Controller = nameof(ClientsController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error",
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }

        // POST api/<ClientsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Client model)
        {
            try
            {
                await _clientService.AddAsync(model);
                return Ok();
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Post),
                    Controller = nameof(ClientsController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error",
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ClientsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Client model)
        {
            try
            {
                if (id == 0)
                {
                    throw (new Exception("Id not provided"));
                }

                model.Id = id;
                _clientService.Update(model);
                return Ok();
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Put),
                    Controller = nameof(ClientsController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error",
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ClientsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw (new Exception("Id not provided"));
                }
                var client = await _clientService.GetByIdAsync(id);
                if (client == null)
                {
                    throw (new Exception("Client not found"));
                }
                _clientService.Remove(client);

                return Ok();
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Delete),
                    Controller = nameof(ClientsController),
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
