using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Rest_Sample.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Rest_SampleContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Rest_SampleContext") ?? throw new InvalidOperationException("Connection string 'Rest_SampleContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
