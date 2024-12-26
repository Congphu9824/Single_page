using Blazor.Services;
using Data.Model;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;

namespace Blazor.Pages.NoteGet
{
    public partial class GetNote
    {
        [Parameter]
        public Guid Id { get; set; }

        [Inject] public IServiceAll _serviceAll { get; set; } = null!;
         
        private List<Note> GridData { get; set; } = new List<Note>();
        public Note Note;
        SfGrid<Note> SfGrid;

        protected override async Task OnInitializedAsync()
        {
            GridData = await _serviceAll.GetNotes();
        }

        private async Task AddNote(Note note)
        {
          await _serviceAll.CreateNote(note);
        }

        private async void OnActionBeginHandler(ActionEventArgs<Note> args)
        {
            if (args.Action == "Add")
            {
                var dataEdit = args.Data;
                await AddNote(dataEdit);
            }
          
        }
    }
}
