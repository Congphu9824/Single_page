using System.Net.Http.Json;
using System.Text.Json;
using Data.DTO;
using Data.Model;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace Blazor.Services
{
    public interface IServiceAll
    {
        Task<List<Staffs>> GetAll();
        Task<List<Notes>> GetNotes();
        
        Task DeleteNote(Guid id);
        Task  DeleteStaff(Guid id);

        Task<bool> CreateData(DapperContext Request);
        Task<bool> UpdateData(DapperContext Request);

    }

    public class ServiceAll( HttpClient http) : IServiceAll
    {
        public async Task<bool> CreateData(DapperContext Request)
        {
            var response = await http.PostAsJsonAsync("api/Dapper/CreateData", Request);
            var conten = response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> UpdateData(DapperContext Request)
        {
            var response = await http.PutAsJsonAsync($"api/Dapper/EditData", Request);
            var content = response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode) 
            {
                
                return true;
            }
            return false;
        }

        public async Task DeleteNote(Guid id)
        {
            var response = await http.DeleteAsync($"api/Dapper/notes/{id}");
            if (response.IsSuccessStatusCode)
            {
                 await http.GetFromJsonAsync<List<Notes>>("api/Dapper/getData?tableName=notes");
            }
        }

        public async Task DeleteStaff(Guid id)
        {
            HttpResponseMessage response = await http.DeleteAsync($"api/Dapper/Staffs/{id}");
            if (response.IsSuccessStatusCode)
            {
                 await http.GetFromJsonAsync<List<Staffs>>("api/Dapper/getData?tableName=Staffs");
            }
        }

        public async Task<List<Staffs>> GetAll()
        {
            var result = await http.GetFromJsonAsync<List<Staffs>>("api/Dapper/getData?tableName=Staffs");
            return result;
        }

        public async Task<List<Notes>> GetNotes()
        {
            var result = await http.GetFromJsonAsync<List<Notes>>("api/Dapper/getData?tableName=notes");
            return result;
        }

     
    }
}
