var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello APIs!");
app.MapGet("/user", () => new {name = "fsalim", age = 24});
app.MapGet("/AddHeader",(HttpResponse response)=> {
    response.Headers.Add("Test","fsalim");
    return "Success";
    });

app.Run();
