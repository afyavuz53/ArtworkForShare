using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtworkForShare.BLL.Concrete.DependencyInjection;
using Microsoft.AspNetCore.Authentication.Cookies;
using ArtworkForShare.UI.MVC.Models.MySession;
using ArtworkForShare.UI.MVC.Helper;

namespace ArtworkForShare.UI.MVC
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScopedBLL();
            services.AddControllersWithViews();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(a => a.LoginPath = new PathString("/Account/Login"));
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSession();
            app.Use((httpContext, nextMiddleware) =>
            {
                httpContext.Session.Set<MyData>("data", new MyData());
                return nextMiddleware();
            });
            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Management}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=Home}/{action=Gallery}/{id?}");
            });
        }
    }
}
