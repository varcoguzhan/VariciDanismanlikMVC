using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using VariciDanismanlikMVC.Data;
using VariciDanismanlikMVC.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<IdentityContext>(
    options=> options.UseSqlite(builder.Configuration["ConnectionString:Sqlite_Connection"]));

builder.Services.AddDbContext<IletisimContext>(options=>{
    var confing= builder.Configuration;
    var connectionString= confing.GetConnectionString("database");
    options.UseSqlite(connectionString);
});
builder.Services.AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStores<IdentityContext>();

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
