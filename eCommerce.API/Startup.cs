﻿using eCommerce.BLL.Services;
using eCommerce.Domain.IRepositories;
using eCommerce.Domain.IServices;
using eCommerce.Infrastructure.Repositories;

namespace eCommerce.API
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            //services
            services.AddScoped<IProduktetService, ProduktetService>();

            //repos
            services.AddScoped<IProduktetRepository, ProduktetRepository>();
        }
    }
}
