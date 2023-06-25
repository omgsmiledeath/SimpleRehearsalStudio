using AspNetRehearsal.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
//app.UseMiddleware<RehearsalListMiddleware>();
//app.UseMiddleware<TestMiddleware>();
app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}",
    defaults: new {controller = "Home" , action = "Index"});

//app.MapGet("/", () => "Hello World!");

app.Run();
