using Microsoft.AspNetCore.Mvc;

using eWellness.BL.Common;
using eWellness.Core.Models;
using eWellness.API.DTOs;
using eWellness.API.Helpers;
using Microsoft.Extensions.Options;
using eWellness.Core.Common.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eWellness.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService { get; set; }
        IActivityLogService _activityLogger { get; set; }

        private readonly JwtSettings _jwtSettings;

        public UsersController(IUserService userService, IActivityLogService activityLogger, IOptions<JwtSettings> jwtSettings)
        {
            _userService = userService;
            _activityLogger = activityLogger;
            _jwtSettings = jwtSettings.Value;
        }

        // GET api/<UsersController>/5
        [Authorize(Roles = "Admin")]
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                if(id == 0)
                {
                    throw (new Exception("Id not provided"));
                }
                return Ok(await _userService.GetByIdAsync(id));
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
                return BadRequest(ex.Message);
            }
        }

        // GET api/<UsersController>/login
        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] LoginDTO request)
        {
            try
            {
                if (request == null)
                {
                    throw (new Exception("Login data not provided"));
                }
                var userId = await _userService.Login(request.Email, request.Password);
                if (userId == -1)
                    return Ok(-1);
                else
                {
                    if(userId == 1)
                        return Ok(GenerateJwtToken(userId, "Admin", _jwtSettings));
                    return Ok(GenerateJwtToken(userId, "User", _jwtSettings));
                }

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
                return BadRequest(ex.Message);
            }
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] User model)
        {
            try
            {
                var user = await _userService.AddAsync(model);
                return Ok(user.Entity);
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Post),
                    Controller = nameof(UsersController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error",
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Put(int id, [FromBody] User model)
        {
            try
            {
                if (id == 0)
                {
                    throw (new Exception("Id not provided"));
                }

                model.Id = id;
                _userService.Update(model);
                return Ok();
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Put),
                    Controller = nameof(UsersController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error",
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<UsersController>/5
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
                var user = await _userService.GetByIdAsync(id);
                if (user == null)
                {
                    throw (new Exception("User not found"));
                }
                _userService.Remove(user);

                return Ok();
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Delete),
                    Controller = nameof(UsersController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error",
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }


        protected string GenerateJwtToken(int userId, string role, JwtSettings jwtSettings)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role, role)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Secret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(jwtSettings.ExpirationMinutes),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
