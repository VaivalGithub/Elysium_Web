using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elysium.Web
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
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.Cookie.Name = ".MarketVeriArti.Session";
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.IdleTimeout = TimeSpan.FromMinutes(180);
                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
            });

            //services.AddAntiforgery(options =>
            //{
            //    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
            //});
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.ConfigureApplicationCookie(options =>
            {
                options.ExpireTimeSpan = TimeSpan.FromDays(30);
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = "/Auth/Index";
            });

            //Filters Registeration Services

            services.AddCors(options =>
            {
                options.AddPolicy(name: "MyPolicy",
                                  builder =>
                                  { });
            });


            services.AddHttpsRedirection(opts =>
            {
                opts.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
            });

            services.AddControllers();
            services.AddMvc(options =>
            {
                // by type  
            });//.AddRazorOptions(options => options.AllowRecompilingViewsOnFileChange = true);

     

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseDeveloperExceptionPage();
            //for clickjacking
            app.Use(async (context, next) =>
            {

                //context.Response.Headers.Add("X-Frame-Options", "SAMEORIGIN");
                //context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
                //context.Response.Headers.Add("referrer-policy", new StringValues("strict-origin-when-cross-origin"));
                //context.Response.Headers.Add(
                //    "Content-Security-Policy",
                //    "script-src 'self'; " +
                //    "style-src 'self'; " +
                //    "img-src 'self'");

                //context.Response.Headers.Add("X-Frame-Options", "SAMEORIGIN");
                //context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
                //context.Response.Headers.Add("referrer-policy", new StringValues("strict-origin-when-cross-origin"));

                await next();
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index_LandingPage}/{id?}");
            });
        }
    }
}
