using CtlWebApp.Core.ICityRepository;
using CtlWebApp.Core.IPeapleRepository;
using CtlWebApp.Core.IStateRepositorys;
using CtlWebApp.DAL.CityConfigs;
using CtlWebApp.DAL.Common;
using CtlWebApp.DAL.PeopleConfig;
using CtlWebApp.DAL.StateConfigs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebApplicationEMPM
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddControllersWithViews();
            services.AddMvc();
            services.AddDbContext<EmployeeContext>(c => c.UseSqlServer(Configuration.GetConnectionString("ctl")));
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IEducatioRepository, EducationRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IWorkHistoryRepository, WorkhistoryRepository>();
            services.AddScoped<IStateRepository, StateRepository>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseExceptionHandler(a =>
            {
                a.Run(async context =>
                {
                   

                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "text/html";

      

                    var exceptionHandlerPathFeature =
                        context.Features.Get<IExceptionHandlerPathFeature>();


                    await context.Response.WriteAsync(exceptionHandlerPathFeature.Error.Message);
                });

            });
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>   
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=People}/{action=EMPM}/{id?}");
            });
        }
    }
}
