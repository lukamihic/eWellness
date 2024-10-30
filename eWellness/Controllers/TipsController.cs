using Microsoft.AspNetCore.Mvc;

using eWellness.BL.Common;
using eWellness.Core.Models;
using eWellness.Core.Parameters;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eWellness.API.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class TipsController : ControllerBase
    {
        ITipService _tipService { get; set; }
        IActivityLogService _activityLogger { get; set; }

        public TipsController(ITipService tipService, IActivityLogService activityLogger)
        {
            _tipService = tipService;
            _activityLogger = activityLogger;
        }

        // GET api/<TipsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                if(id == 0)
                {
                    throw (new Exception("Id not provided"));
                }
                return Ok(await _tipService.GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Get),
                    Controller = nameof(TipsController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error", 
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }

        // GET api/<TipsController>
        [HttpGet]
        public async Task<ActionResult> GetAll([FromQuery] BasePagingParameters filter)
        {
            try
            {
                return Ok(await _tipService.FilterAsync(filter));
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Get),
                    Controller = nameof(TipsController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error",
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }

        // POST api/<TipsController>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Post([FromBody] Tip model)
        {
            try
            {
                await _tipService.AddAsync(model);
                return Ok();
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Post),
                    Controller = nameof(TipsController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error",
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<TipsController>/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Put(int id, [FromBody] Tip model)
        {
            try
            {
                if (id == 0)
                {
                    throw (new Exception("Id not provided"));
                }

                model.Id = id;
                _tipService.Update(model);
                return Ok();
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Put),
                    Controller = nameof(TipsController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error",
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<TipsController>/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw (new Exception("Id not provided"));
                }
                var tip = await _tipService.GetByIdAsync(id);
                if (tip == null)
                {
                    throw (new Exception("Tip not found"));
                }
                _tipService.Remove(tip);

                return Ok();
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Delete),
                    Controller = nameof(TipsController),
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
