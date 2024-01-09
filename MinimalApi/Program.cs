var builder = WebApplication.CreateBuilder(args);
builder.AddDapper();
builder.AddServices();
builder.AddOpenAPI();
builder.Services.AddCarter();

var app = builder.Build();
app.UseServices();
app.MapCarter();
app.UseOpenAPI(string.Empty);

app.Run();
