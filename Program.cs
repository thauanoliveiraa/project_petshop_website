using Microsoft.EntityFrameworkCore;
using PegasusPetshop.Database;
using Microsoft.Extensions.DependencyInjection;
using PegasusPetshop.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
string mySqlConnection = builder.Configuration.GetConnectionString("DefaultDatabase"); // String de conexão

builder.Services.AddDbContext<PetshopContext>(opt => { // Config banco

    opt.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection));

});


builder.Services.AddScoped<IPetshopRepository, PetshopRepository>();
builder.Services.AddScoped<IPetsRepository, PetsRepository>();
builder.Services.AddScoped<IProdutosRepository, ProdutosRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

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
