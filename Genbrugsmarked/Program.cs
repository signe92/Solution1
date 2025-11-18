using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Genbrugsmarked;
using Blazored.LocalStorage;
using Core.Klasser;
using Genbrugsmarked.Service;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<BrugerRepo>();

// brug af local storage
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddSingleton<IAnnonceService, AnnonceService>();




await builder.Build().RunAsync();