using Blazor.Services;
using Data.Model;
using Data.DTO;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using System.Text.Json;
using static System.Net.WebRequestMethods;
using Syncfusion.Blazor.Grids.Internal;
using System.Net.Http.Json;
using Syncfusion.Blazor.Lists;
using Syncfusion.Blazor.Navigations;


namespace Blazor.Pages.NoteGet
{
    public partial class GetNote
    {
        [Parameter]
        public Guid Id { get; set; }

        [Inject] public IServiceAll _serviceAll { get; set; } = null!;
        [Inject] HttpClient http { get; set; }
        private List<Notes> GridData { get; set; } = new List<Notes>();
        public Notes Note;
        SfGrid<Notes> SfGrid;
        private string SearchText { get; set; } = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            GridData = await _serviceAll.GetNotes();
        }

        private async void OnActionBeginHandler(ActionEventArgs<Notes> args)
        {
            if (args.Action == "Delete")
            {
                var DataDelete = args.Data.Id;
                if (DataDelete != null)
                {
                    await DeleteNote(DataDelete);
                }
            }
            else if(args.Action == "Add")
            {
                var jsonData = JsonSerializer.Serialize(args.Data);
                var request = new DapperContext()
                {
                    EntityType = "Notes",
                    JsonData = jsonData
                };
                var result = await _serviceAll.CreateData(request);
                if (result)
                {
                    await SfGrid.Refresh();
                }
            }
            else if (args.Action == "Edit")
            {
                var jsonData = JsonSerializer.Serialize(args.Data);
                var request = new DapperContext()
                {
                    EntityType = "Notes",
                    JsonData = jsonData
                };
                var result = await _serviceAll.UpdateData(request);
                if (result)
                {
                    await SfGrid.Refresh();
                }
            }
        }

        public async Task ToolBarClickHandle(ClickEventArgs args)
        {
            if (args.Item.Text == "Add")
            {
                await SfGrid.AddRecordAsync();
            }
            else if(args.Item.Text == "edit")
            {
                await SfGrid.StartEditAsync();
            }
            else if (args.Item.Text == "delete")
            {
                await SfGrid.DeleteRecordAsync();
            }
            else if( args.Item.Text == "Search")
            {
                await SfGrid.SearchAsync(args.Name);
            }
        }


        public async Task DeleteNote(Guid id)
        {
            await _serviceAll.DeleteNote(id);
        }
    }
}
