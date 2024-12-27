using Blazor;
using Blazor.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<IServiceAll, ServiceAll>();

//Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NMaF5cXmBCf0x0RHxbf1x1ZFxMYVlbQXVPIiBoS35RckRhW31ccXVQQ2lVV0Fz");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7284/") });
builder.Services.AddSyncfusionBlazor();

await builder.Build().RunAsync();
