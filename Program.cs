using Microsoft.EntityFrameworkCore;
using TicketBookingApplication.Data;
using TicketBookingApplication.Models;
using System;





var builder = WebApplication.CreateBuilder(args);

//Configuration
builder.Configuration.AddJsonFile("appsettings.json");

// CONNECTION STRING LINKED TO APPSETTINGS JSON

var connectionString = builder.Configuration.GetConnectionString("DatabaseCon");

builder.Services.AddDbContext<ApplicationDbContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseCon")      
));



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
// seed Database
AppDbInitializer.Seed(app);




// movies 
//builder.Services.AddScoped<MovieService>();