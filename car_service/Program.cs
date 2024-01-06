using car_service.BL.Implementations;
using car_service.BL.Interfaces;
using car_service.DAL.Implementations;
using car_service.DAL.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<ICarBL, CarBL>();
builder.Services.AddSingleton<ICarDAL, CarDAL>();
builder.Services.AddSingleton<IOrderBL, OrderBL>();
builder.Services.AddSingleton<IOrderDAL, OrderDAL>();
builder.Services.AddSingleton<ICustomerBL, CustomerBL>();
builder.Services.AddSingleton<ICustomerDAL, CustomerDAL>();
builder.Services.AddSingleton<IServiceBL, ServiceBL>();
builder.Services.AddSingleton<IServiceDAL, ServiceDAL>();

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
    name: "customers",
    pattern: "{controller}/{action=Index}");

app.MapControllerRoute(
    name: "orders",
    pattern: "{controller}/{action=Index}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
