var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();

var app = builder.Build();


app.MapControllerRoute(
    name:"default",
    pattern :"{controller=Default}/{action=Index}"
    );


app.UseStaticFiles();

app.Run();
