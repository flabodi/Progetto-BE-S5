using Microsoft.EntityFrameworkCore;
using PoliziaApp.Services;
using Progetto_BE_S5.Models;
using Progetto_BE_S5.Services;
using Progetto_BE_S5.Data;


var builder = WebApplication.CreateBuilder(args);

// Aggiunta della Connection String
builder.Services.AddDbContext<ProgettoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PoliziaDB")));

// Registrazione dei servizi senza interfaccia
builder.Services.AddScoped<AnagraficaServices>();
builder.Services.AddScoped<ViolazioneServices>();
builder.Services.AddScoped<VerbaleServices>();
builder.Services.AddScoped<StatisticheServices>();

// Aggiunta del supporto per MVC con Views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurazione del Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
