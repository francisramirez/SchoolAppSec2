using Microsoft.EntityFrameworkCore;
using School.Data.Context;
using School.Data.Daos;
using School.Data.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddDbContext<SchoolContext>(options => options.UseInMemoryDatabase("SchoolDb"));

builder.Services.AddScoped<IDaoDepartment, DaoDepartment>();

builder.Services.AddScoped<ICourseDb, CourseDb>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
