using Microsoft.EntityFrameworkCore;
using RentadeCarros.Artefactos;
using RentadeCarros.Client.Pages;
using RentadeCarros.Components;
using RentadeCarros.Repositoriodecarros;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<RentadeCarrosDBContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("CadenaConexion")));
builder.Services.AddScoped<IRepositorioUsuarios, RepositorioUsuarios>();
builder.Services.AddScoped<IRepositorioVehiculo, RepositorioVehiculos>();
builder.Services.AddScoped<IRepositorioReservaciones, RepositorioReservaciones>();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(RentadeCarros.Client._Imports).Assembly);

app.Run();
