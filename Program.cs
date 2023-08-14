using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
   {
       c.SwaggerDoc("v1", new OpenApiInfo { Title = "Web APIs", Description = "Keep track of your tasks", Version = "v1" });
   });
var app = builder.Build();

app.MapGet("/", () => "Hello Maddy!!");
app.UseSwagger();
app.UseSwaggerUI(c =>
   {
     c.SwaggerEndpoint("/swagger/v1/swagger.json", "Web APIs");
   });



app.Run();
