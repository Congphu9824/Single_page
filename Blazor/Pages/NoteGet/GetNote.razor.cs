using Blazor.Services;
using Data.Model;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using static System.Net.WebRequestMethods;
using Syncfusion.Blazor.Grids.Internal;
using System.Net.Http.Json;

namespace Blazor.Pages.NoteGet
{
    public partial class GetNote
    {
        [Parameter]
        public Guid Id { get; set; }

        [Inject] public IServiceAll _serviceAll { get; set; } = null!;
        [Inject] HttpClient http { get; set; }
        private List<Note> GridData { get; set; } = new List<Note>();
        public Note Note;
        SfGrid<Note> SfGrid;

        protected override async Task OnInitializedAsync()
        {
            GridData = await _serviceAll.GetNotes();
        }

        private async void OnActionBeginHandler(ActionEventArgs<Note> args)
        {
            if (args.Action == "Delete")
            {
                var DataDelete = args.Data.Id;
                if (DataDelete != null)
                {
                    await DeleteNote(DataDelete);
                }
            }
        }

        public async Task DeleteNote(Guid id)
        {
            await _serviceAll.DeleteNote(id);
        }
    }
}
