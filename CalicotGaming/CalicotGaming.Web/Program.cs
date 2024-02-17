using CalicotGaming.Web.Models;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// inject the entityframework dbcontext
if(builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<CalicotGamingDbContext>(options =>
           options.UseInMemoryDatabase("CalicotGamingDb"));
}
else
{
    builder.Services.AddDbContext<CalicotGamingDbContext>(options =>
           options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


// seed the dbcontext if we're in the dev environment
if(app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope(); // we need to create a scope to resolved scoped services.
    var dbContext = scope.ServiceProvider.GetRequiredService<CalicotGamingDbContext>();
    Helpers.SeedDbContext(dbContext);
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



// https://stackoverflow.com/questions/72447401/cannot-resolve-scoped-service-from-root-provider-in-asp-net-core-6