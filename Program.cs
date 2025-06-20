
using EmployeeMS.Models;

var builder = WebApplication.CreateBuilder(args);

// Register MVC services
builder.Services.AddControllersWithViews().AddXmlDataContractSerializerFormatters();
builder.Services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
var app = builder.Build();

app.UseStaticFiles();

// Use routing and endpoints
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapDefaultControllerRoute(); // maps to HomeController/Index by default
});

app.Run(); 
