using Hamburgueria.DATA.Infrastructure.Mapping;
using Hamburgueria.DATA.Interfaces;
using Hamburgueria.DATA.Interfaces.IServices;
using Hamburgueria.DATA.Repository;
using Hamburgueria.DATA.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//AutoMapper
builder.Services.AddAutoMapper(typeof(DomainToDTOMapping));

//INJECAO DE DEPENDENCIA REPOSITORY
builder.Services.AddTransient<IIngredienteRepository, IngredienteRepository>();

//INJECAO DE DEPENDENCIA SERVICE
builder.Services.AddTransient<IIngredienteService, IngredienteService>();

var app = builder.Build();
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
