

namespace HRIS.Client.Services.Master_Data_Service.DivisionService
{
    public class DivisionService : IDivisionService
    {
        private readonly HttpClient _http;

        public DivisionService(HttpClient http)
        {
            _http = http;
        }

        public List<DDivisionT> Divisions { get ; set; } = new List<DDivisionT>();

        public async Task GetDivisions()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<DDivisionT>>>("api/DDivision");
            if (result != null && result.Data != null)
                Divisions = result.Data;
        }
    }
}
