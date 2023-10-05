namespace HRIS.Server.Services.DivisionService
{
    public interface IDivisionService
    {
        Task<ServiceResponse<List<DDivisionT>>> GetDivisionAsync();
    }
}
