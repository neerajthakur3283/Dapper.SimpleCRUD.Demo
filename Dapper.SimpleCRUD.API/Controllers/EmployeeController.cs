using Dapper.SimpleCRUD.Core.Interfaces;
using Dapper.SimpleCRUD.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dapper.SimpleCRUD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _empServices;
        public EmployeeController(IEmployeeServices empServices)
        {
            _empServices = empServices;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllData()
        {
            return Ok(await _empServices.GetAllDataAsync());
        }

        [HttpPost("create")]
        public async Task<IActionResult> InsertData(Employee obj)
        {
            return Ok(await _empServices.InsertDataAsync(obj));
        }
        [HttpPost("update")]
        public async Task<IActionResult> UpdateData(Employee obj)
        {
            return Ok(await _empServices.UpdateDataAsync(obj));
        }
        [HttpPost("delete")]
        public async Task<IActionResult> DeleteData(int id)
        {
            return Ok(await _empServices.DeleteDataAsync(id));
        }
        [HttpPost("getById")]
        public async Task<IActionResult> GetDataById(int id)
        {
            return Ok(await _empServices.GetDataByIdAsync(id));
        }
    }
}