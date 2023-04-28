var builder = WebApplication.CreateBuilder(args);
// var env = builder.Environment;

IConfiguration configurations = builder.Configuration;
// IConfiguration configurations = builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
//     .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true).Build();

var appSettings = configurations.Get<AppSettings>();

builder.Services.AddDependencies(appSettings);

builder.Services.AddControllersWithViews();

builder.Services.AddCors(p => p.AddPolicy("corspolicy", build =>
{
    build.WithOrigins().AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseCors("corspolicy");

app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
