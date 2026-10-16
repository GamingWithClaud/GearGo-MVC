var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Register each interface with its implementation so ASP.NET Core can inject them where needed.
builder.Services.AddScoped<GearGo.Repositories.EquipmentRepository>();
builder.Services.AddScoped<GearGo.Services.EquipmentService>();

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