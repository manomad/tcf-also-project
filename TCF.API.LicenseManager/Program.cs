using Microsoft.EntityFrameworkCore;
using TCF.API.LicenseManager.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<LicenseInfoContext>(options =>
    options.UseCosmos(
        builder.Configuration["CosmosDb:AccountEndpoint"] ?? "",
        builder.Configuration["CosmosDb:AccountKey"] ?? "",
        builder.Configuration["CosmosDb:DatabaseName"] ?? ""));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUi(options =>
    {
        options.Path = "/swagger";
        options.DocumentPath = "/openapi/v1.json";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
