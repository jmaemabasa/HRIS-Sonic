namespace HRIS.Server.Services.DivisionService
{
    public class DivisionService : IDivisionService
    {
        private readonly DataContext _context;

        public DivisionService(DataContext context)
        {
            _context = context;
        }

        //GET Divisions
        public async Task<ServiceResponse<List<DDivisionT>>> GetDivisionAsync()
        {
            var response = new ServiceResponse<List<DDivisionT>>
            {
                Data = await _context.DDivisionT.ToListAsync()
            };
            return response;
        }
    }
}
