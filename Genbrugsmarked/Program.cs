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



// brug af local storage
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<IAnnonceService, AnnonceService>();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IUserSessionService, UserSessionService>();




await builder.Build().RunAsync();