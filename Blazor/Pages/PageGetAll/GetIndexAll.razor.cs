using Blazor.Services;
using Data.Model;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Navigations;

namespace Blazor.Pages.PageGetAll
{
    public partial class GetIndexAll
    {
        [Parameter]
        public Guid Id { get; set; }

        [Inject] public IServiceAll _serviceAll { get; set; } = null!;

        private List<Staff> GridData { get; set; } = new List<Staff>();
        private Staff Staff = new Staff();
        SfGrid<Staff> GridRef;

        protected override async Task OnInitializedAsync()
        {
            GridData = await _serviceAll.GetAll();
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
