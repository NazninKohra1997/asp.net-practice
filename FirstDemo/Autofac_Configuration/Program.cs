using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac_Configuration;
using Autofac_Configuration.Models;

var builder = WebApplication.CreateBuilder(args);


//for Autofac


builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.RegisterModule(new WebModule());
}
);

//for AutoFac


// Add services to the container.
builder.Services.AddControllersWithViews();


//For DI
builder.Services.AddSingleton<IGetPhoneCall, CustomerCare>();
//For DI

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
