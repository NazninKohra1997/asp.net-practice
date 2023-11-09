using Assignment_Logger.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Sinks.Email;
using System.Configuration;
using System.Net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using static System.Net.Mime.MediaTypeNames;
using System.Net.Sockets;
using System.Threading.Channels;
using Microsoft.Identity.Client;
using Org.BouncyCastle.Crypto.Tls;
using MailKit.Security;

var builder = WebApplication.CreateBuilder(args);


//for serilog

builder.Host.UseSerilog((ctx, lc) => lc.MinimumLevel.Debug()
                                    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                                  .Enrich.FromLogContext()
                                .ReadFrom.Configuration(builder.Configuration)
);

//for serilog









try
{

    // Add services to the container.
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(connectionString));
    builder.Services.AddDatabaseDeveloperPageExceptionFilter();

    builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
        .AddEntityFrameworkStores<ApplicationDbContext>();
    builder.Services.AddControllersWithViews();





    var app = builder.Build();



    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseMigrationsEndPoint();
    }
    else
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
    app.MapRazorPages();

    app.Run();
    Log.Information("Logging is starting");

}

catch (Exception ex)
{


    Log.Fatal(ex, "Error is occuring");
 
  
}


finally
{
    Log.CloseAndFlush();
}

