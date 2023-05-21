using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using eWellness.BL.Common;
using eWellness.Core.Common.Models;
using eWellness.Core.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eWellness.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService { get; set; }
        IActivityLogService _activityLogger { get; set; }

        public UsersController(IUserService userService, IActivityLogService activityLogger)
        {
            _userService = userService;
            _activityLogger = activityLogger;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            try
            {
                return await _userService.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Get),
                    Controller = nameof(UsersController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error", 
                    UserId = null
            });
                return new User();
            }
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
