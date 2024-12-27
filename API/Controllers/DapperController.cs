using System.Reflection.Metadata;
using API.Repositories;
using Data.Model;
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

        [HttpDelete("{tableName}/{id}")]
        public async Task<IActionResult> DeleteData(string tableName, Guid id)
        {
            try
            {
                var Parameter = "UsingDelete";
                var param = new { parameter =  Parameter, tablename = tableName, @KeyData = id };
                var result = await _IrepStaffStore.GetListObjectAsync<object>("DeleteData", param);
                return Ok(result);
            }
            catch (Exception ex) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }
    }
}
