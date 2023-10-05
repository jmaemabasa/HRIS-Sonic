namespace HRIS.Client.Services.Master_Data_Service.DivisionService
{
    public interface IDivisionService
    {
        List<DDivisionT> Divisions { get; set; }
        Task GetDivisions();
    }
}
