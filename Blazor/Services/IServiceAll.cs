using System.Net.Http.Json;
using System.Text.Json;
using Data.Model;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace Blazor.Services
{
    public interface IServiceAll
    {
        Task<List<Staff>> GetAll();
        Task<List<Note>> GetNotes();
        
        //
        Task DeleteNote(Guid id);
        Task  DeleteStaff(Guid id);
    }

    public class ServiceAll( HttpClient http) : IServiceAll
    {
        public async Task DeleteNote(Guid id)
        {
            var response = await http.DeleteAsync($"api/Dapper/notes/{id}");
            if (response.IsSuccessStatusCode)
            {
                 await http.GetFromJsonAsync<List<Note>>("api/Dapper/getData?tableName=notes");
            }
        }

        public async Task DeleteStaff(Guid id)
        {
            HttpResponseMessage response = await http.DeleteAsync($"api/Dapper/Staffs/{id}");
            if (response.IsSuccessStatusCode)
            {
                 await http.GetFromJsonAsync<List<Staff>>("api/Dapper/getData?tableName=Staffs");
            }
        }

        public async Task<List<Staff>> GetAll()
        {
            var result = await http.GetFromJsonAsync<List<Staff>>("api/Dapper/getData?tableName=Staffs");
            return result;
        }

        public async Task<List<Note>> GetNotes()
        {
            var result = await http.GetFromJsonAsync<List<Note>>("api/Dapper/getData?tableName=notes");
            return result;
        }
    }
}
