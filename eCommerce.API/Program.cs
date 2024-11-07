using eCommerce.API;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using eCommerce.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var connStr = builder.Configuration.GetConnectionString("DBconn");
builder.Services.AddDbContext<DB>(options => options.UseSqlServer(connStr));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
