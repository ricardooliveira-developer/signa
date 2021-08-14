using APISigna.domain.Handles;
using APISigna.domain.Interfaces;
using APISigna.domain.Models;
using APISigna.infra.Data;
using APISigna.infra.Repository;
using Dapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APISigna
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            AddContexts(services);
            AddRepositories(services);
            AddHandlers(services);
            MapEntities();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        private void AddContexts(IServiceCollection services)
        {
            services.AddDbContext<Context>(ServiceLifetime.Transient);
        }

        private void AddRepositories(IServiceCollection services)
        {
            services.AddTransient<IOwner, OwnerRepository>();
            services.AddTransient<ICats, CatsRepository>();
            services.AddTransient<IDogs, DogsRepository>();
        }

        private void AddHandlers(IServiceCollection services)
        {
            services.AddTransient<OwnerHandler, OwnerHandler>();
            services.AddTransient<CatsHandler, CatsHandler>();
            services.AddTransient<DogsHandler, DogsHandler>();
        }
        private void MapEntities()
        {
            MapEntity(typeof(OwnerModel));
            MapEntity(typeof(CatsModel));
            MapEntity(typeof(DogsModel));
        }

        private void MapEntity(Type entityType)
        {
            SqlMapper.SetTypeMap(entityType, new CustomPropertyTypeMap(
                entityType, (type, columnName) =>
                type.GetProperties().FirstOrDefault(prop =>
                    prop.GetCustomAttributes(false).OfType<ColumnAttribute>().Any(attr => attr.Name == columnName)
                )
            ));
        }
    }
}
