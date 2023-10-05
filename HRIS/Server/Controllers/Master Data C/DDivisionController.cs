using Microsoft.AspNetCore.Mvc;

namespace HRIS.Server.Controllers.Master_Data_C
{
    [Route("api/[controller]")]
    [ApiController]
    public class DDivisionController : ControllerBase
    {
        private readonly DataContext _context;

        public DDivisionController(DataContext context)
        {
            _context = context;
        }

        //Get / Display Divisions
        [HttpGet]
        public async Task<ActionResult<List<DDivisionT>>> GetDivision()
        {
            var divisions = await _context.DDivisionT.ToListAsync();
            return Ok(divisions);
        }
    }
}
