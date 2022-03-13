using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using WebShopAYuri.DbModels;
using WebShopAYuri.Repositories;
using WebShopAYuri.Services;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using WebShopAYuri.Controllers;

namespace WebShopAYuri
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private void SetupDBContext(IServiceCollection service)
        {
            var connStr = Configuration.GetConnectionString("MojaBaza");
            service.AddDbContext<WebShopAndeloContext>(options => options.UseSqlServer(connStr));
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            SetupDBContext(services);
            services.AddScoped<ProizvodiRepository>();
            services.AddScoped<ProizvodiService>();
            services.AddSession(options => { options.IdleTimeout = TimeSpan.FromSeconds(3600); });

        }
        public class sessionAdminTimeout : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext context)
            {
                if (context.HttpContext.Session == null || !context.HttpContext.Session.TryGetValue("sessionAdmin", out byte[] v))
                {
                    context.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                    {
                        controller = "Log",
                        action = "LogInAdmin"
                    }));
                }
                base.OnActionExecuting(context);
            }
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            
            app.UseRouting();

            app.UseAuthorization();

            app.UseAuthentication();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(name: "Proizvodi",
                                             pattern: "proizvodi",
                                             defaults: new { controller = "Home", action = "Index" });
                endpoints.MapControllerRoute(name: "Mobiteli",
                                             pattern: "proizvodi/mobiteli",
                                             defaults: new { controller = "Home", action = "Mobiteli" });
                endpoints.MapControllerRoute(name: "Tableti",
                                             pattern: "proizvodi/tableti",
                                             defaults: new { controller = "Home", action = "Tableti" });
                endpoints.MapControllerRoute(name: "Smart watches",
                                             pattern: "proizvodi/pametnisatovi",
                                             defaults: new { controller = "Home", action = "Satovi" });
                endpoints.MapControllerRoute("Log", "Log",
                   new { controller = "Log", action = "Log" });
                endpoints.MapControllerRoute("LogInAdmin", "LogInAdmin",
                    new { controller = "Log", action = "LogInAdmin" });

            });
        }
    }
}
