using Microsoft.AspNetCore.Mvc;

namespace HRIS.Server.Controllers.Master_Data_C
{
    [Route("api/[controller]")]
    [ApiController]
    public class DDivisionController : ControllerBase
    {
        private readonly IDivisionService _divisionService;

        public DDivisionController(IDivisionService divisionService)
        {
            _divisionService = divisionService;
        }

        //Get / Display Divisions
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<DDivisionT>>>> GetDivision()
        {
            var result = await _divisionService.GetDivisionAsync();
            return Ok(result);
        }
    }
}
