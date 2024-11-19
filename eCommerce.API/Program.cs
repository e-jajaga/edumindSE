using eCommerce.API;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using eCommerce.Infrastructure.Data;
using eCommerce.BLL.Services;
using eCommerce.Domain.IRepositories;
using eCommerce.Domain.IServices;
using eCommerce.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//var startup = new Startup(builder.Configuration);
//startup.ConfigureServices(builder.Services);

var connStr = builder.Configuration.GetConnectionString("DBconn");
builder.Services.AddDbContext<DB>(options => options.UseSqlServer(connStr));

// Register GenericRepository as the implementation of IGenericRepository
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

//services
builder.Services.AddScoped<IProduktetService, ProduktetService>();

//repos
builder.Services.AddScoped<IProduktetRepository, ProduktetRepository>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


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
