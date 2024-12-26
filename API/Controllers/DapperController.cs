using API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DapperController : ControllerBase
    {
        private readonly IRepStaffStore _IrepStaffStore;
        public DapperController(IRepStaffStore repStaffStore)
        {
            _IrepStaffStore = repStaffStore;    
        }

        [HttpGet("getData")]
        public async Task<IActionResult> Getdata(string tableName, string condition = null, string coulums = null)
        {
            try
            {
                var param = new { parameter = "StoreData", Condition = condition, Colums = tableName };
                var result = await _IrepStaffStore.GetListObjectAsync<object>("GetData", param);
                return Ok(result);
            }
            catch (Exception ex) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("CreateAll")]
        public async Task<IActionResult> Create(object entity)
        {
            try
            {
                _IrepStaffStore.AddAsync(entity);

            }
            catch (Exception ex) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
            return Ok();    
        }
    }
}
