var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// 1. ADDED: Register Entity Framework Core with SQL Server (From Lab 2.3 - Marko's work)
builder.Services.AddDbContext<GearGo.Data.GearGoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register each interface with its implementation so ASP.NET Core can inject them where needed.
builder.Services.AddScoped<GearGo.Repositories.IEquipmentRepository, GearGo.Repositories.EquipmentRepository>();
builder.Services.AddScoped<GearGo.Services.IEquipmentService, GearGo.Services.EquipmentService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

// Log request metadata after routing and before the request reaches the endpoint.
app.UseMiddleware<GearGo.Middleware.RequestLoggingMiddleware>();

app.UseAuthorization();

app.MapStaticAssets();

app.UseStaticFiles();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
