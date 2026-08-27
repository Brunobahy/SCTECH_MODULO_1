using MinhaPrimeiraAPI.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();


app.UseSwaggerUI( options =>
{
    options.SwaggerEndpoint("/openapi/v1.json","API V1");
});



app.UseHttpsRedirection();

app.MapControllers();

app.MapGet("/",()=>"Hello World!");
app.MapGet("/banana",()=>"BANANAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA!");


app.Run();
