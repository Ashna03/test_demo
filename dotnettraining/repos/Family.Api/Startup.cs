using Family_DAL.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Family_DAL.Repository;
using Family_DAL.Interface;
using Family_BAL.Service;
using Family_DAL.Models;

namespace Family.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;         //created
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;                     //changed with created private _configuration
        }

        //public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string conString = _configuration.GetConnectionString("familyConnectionString");         //created for connection
            services.AddDbContext<FamilyDBContext>(options => options.UseSqlServer(conString));               //created for connection
            services.AddTransient<IRepository<Person>, RepositoryPerson>();
            services.AddTransient<PersonService, PersonService>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Family.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, FamilyDBContext context
)
        {
            if (env.IsDevelopment())
            {
                context.Database.Migrate();

                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Family.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
