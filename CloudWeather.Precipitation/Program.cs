using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/observation/{zip}", (string zip, [FromQuery] int? day) => { 
    return Results.Ok(zip);
});

app.Run();
