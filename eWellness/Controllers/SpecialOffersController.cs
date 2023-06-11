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
    public class SpecialOffersController : ControllerBase
    {
        ISpecialOfferService _specialOfferService { get; set; }
        IActivityLogService _activityLogger { get; set; }

        public SpecialOffersController(ISpecialOfferService specialOfferService, IActivityLogService activityLogger)
        {
            _specialOfferService = specialOfferService;
            _activityLogger = activityLogger;
        }

        // GET api/<SpecialOffersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                if(id == 0)
                {
                    throw (new Exception("Id not provided"));
                }
                return Ok(await _specialOfferService.GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Get),
                    Controller = nameof(SpecialOffersController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error", 
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }

        // GET api/<SpecialOffersController>
        [HttpGet]
        public async Task<ActionResult> GetAll([FromBody] BasePagingParameters filter)
        {
            try
            {
                return Ok(await _specialOfferService.FilterAsync(filter));
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Get),
                    Controller = nameof(SpecialOffersController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error",
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }

        // POST api/<SpecialOffersController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] SpecialOffer model)
        {
            try
            {
                await _specialOfferService.AddAsync(model);
                return Ok();
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Post),
                    Controller = nameof(SpecialOffersController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error",
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<SpecialOffersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] SpecialOffer model)
        {
            try
            {
                if (id == 0)
                {
                    throw (new Exception("Id not provided"));
                }

                model.Id = id;
                _specialOfferService.Update(model);
                return Ok();
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Put),
                    Controller = nameof(SpecialOffersController),
                    Device = this.Request.HttpContext.GetServerVariable("HTTP_USER_AGENT"),
                    Exception = ex.ToString(),
                    LogType = "Error",
                    UserId = null
                });
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<SpecialOffersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    throw (new Exception("Id not provided"));
                }
                var specialOffer = await _specialOfferService.GetByIdAsync(id);
                if (specialOffer == null)
                {
                    throw (new Exception("SpecialOffer not found"));
                }
                _specialOfferService.Remove(specialOffer);

                return Ok();
            }
            catch (Exception ex)
            {
                await _activityLogger.AddAsync(new ActivityLog()
                {
                    ActionName = nameof(Delete),
                    Controller = nameof(SpecialOffersController),
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
