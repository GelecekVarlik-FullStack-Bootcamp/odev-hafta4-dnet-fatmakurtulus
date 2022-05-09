using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkManSys.Bll;
using WorkManSys.Dal.Abstract;
using WorkManSys.Dal.Concrete.Entityframework.Context;
using WorkManSys.Dal.Concrete.Entityframework.Repository;
using WorkManSys.Dal.Concrete.Entityframework.UnitOfWork;
using WorkManSys.Interface;

namespace WorkManSys.WebApi
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
            #region JwtTokenService
            #endregion

            #region ApplicationContext
            services.AddDbContext<WorkManagementSystemContext>();
            services.AddScoped<DbContext, WorkManagementSystemContext>();
            #endregion


            #region ServiceSection
            services.AddScoped<IPersonalService, PersonalManager>();
           // services.AddScoped<IRequestService, RequestManager>();

            #endregion

            #region RepositorySection
            services.AddScoped<IPersonalRepository, PersonalRepository>();
           // services.AddScoped<IRequestRepository, RequestRepository>();

            #endregion
            //services.AddDbContext<NorthwindPatikaDbContext>(ob=>ob.UseSqlServer(Configuration.GetConnectionString("SqlServerr")));
            #region UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WorkManSys.WebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WorkManSys.WebApi v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
