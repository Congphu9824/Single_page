using System.Text.Json;
using Blazor.Services;
using Data.DTO;
using Data.Model;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Navigations;
using static System.Net.WebRequestMethods;

namespace Blazor.Pages.PageGetAll
{
    public partial class GetIndexAll
    {
        [Parameter]
        public Guid Id { get; set; }

        [Inject] public IServiceAll _serviceAll { get; set; } = null!;

        private List<Staffs> GridData { get; set; } = new List<Staffs>();
        private Staffs Staff = new Staffs();
        SfGrid<Staffs> GridRef;

        protected override async Task OnInitializedAsync()
        {
            GridData = await _serviceAll.GetAll();
        }

        private async void OnActionBeginHandler(ActionEventArgs<Staffs> args)
        {
            if (args.Action == "Delete")
            {
                var DataDelete = args.Data.Id;
                if (DataDelete != null)
                {
                    await DeleteStaff(DataDelete);
                }
            }
            else if(args.Action == "Add")
            {
                var jsonData = JsonSerializer.Serialize(args.Data);
                var request = new DapperContext()
                {
                    EntityType = "Staffs",
                    JsonData = jsonData
                };
                var result = await _serviceAll.CreateData(request);
                if (result)
                {
                    await GridRef.Refresh();
                }
            }
            else if(args.Action == "Edit")
            {
                var JsonData = JsonSerializer.Serialize(args.Data);
                var request = new DapperContext()
                {
                    EntityType = "Staffs",
                    JsonData = JsonData
                };
                var result = _serviceAll.UpdateData(request);
                if (result.IsCompletedSuccessfully)
                {
                    await GridRef.Refresh();
                }
            }
        }
        public async Task ToolbarClickHandler(Syncfusion.Blazor.Navigations.ClickEventArgs args)
        {
            if (args.Item.Text == "Add")
            {
              await  this.GridRef.AddRecordAsync();
            }
            else if(args.Item.Text == "edit")
            {
                await this.GridRef.StartEditAsync();
            }
            else if (args.Item.Text == "delete")
            {
                await GridRef.DeleteRecordAsync();
            }
        }
        private async Task DeleteStaff(Guid id)
        {
            await _serviceAll.DeleteStaff(id);
        }

        private async Task ToolbarClickhandle(ClickEventArgs args)
        {
            if(args.Item.Text == "Pdf Export")
            {
                this.GridRef.PdfExport();
            }
        }
    }
}
