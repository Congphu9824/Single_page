using System.Net.Http.Json;
using Data.Model;
using static System.Net.WebRequestMethods;

namespace Blazor.Services
{
    public interface IServiceAll
    {
        Task<List<Staff>> GetAll();
        Task<List<Note>> GetNotes();

        Task<Note> CreateNote(Note note);
    }

    public class ServiceAll( HttpClient http) : IServiceAll
    {
        public async Task<Note> CreateNote(Note note)
        {
            var response = await http.PostAsJsonAsync("api/Dapper/CreateAll?tablename=notes", note);
            if (response.IsSuccessStatusCode)
            {
                var createdNote = await response.Content.ReadFromJsonAsync<Note>();
                return createdNote;
            }
            else
            {
                throw new Exception($"Error: {response.StatusCode}");
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
