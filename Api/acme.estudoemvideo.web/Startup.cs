using acme.estudoemvideo.infra.Config;
using acme.estudoemvideo.util.InjectDependencie;
using acme.estudoemvideo.util.ViewModel.Seguranca;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using MySql.EntityFrameworkCore.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web
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
            services.AddDbContext<Context>(options => options.UseMySQL(Configuration.GetConnectionString("EstudoEmVideo")));

            services.AddScoped<Context, Context>();
            services = new InjecaoDeDependencia().InjetaDependecia(services);

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.Configure<FormOptions>(options =>
            {
                // Set the limit to 256 MB
                options.MultipartBodyLengthLimit = 5368710000;
            });
            services.AddRazorPages()
    .AddRazorPagesOptions(options =>
    {

        options.Conventions
            .AddPageApplicationModelConvention("/ModalCompletoCadastroVideo",
                model =>
                {
                    model.Filters.Add(
                        new SeguranAntiforgeryTokenCookie());
                    model.Filters.Add(
                        new DisableFormValueModelBindingAttribute());
                });
        options.Conventions
            .AddPageApplicationModelConvention("/StreamedSingleFileUploadPhysical",
                model =>
                {
                    // Handle requests up to 50 MB
                    model.Filters.Add(
                        new RequestSizeLimitAttribute(5368710000));
                });
        options.Conventions
                      .AddPageApplicationModelConvention("/StreamedSingleFileUploadPhysical",
                          model =>
                          {
                              model.Filters.Add(
                                  new SeguranAntiforgeryTokenCookie());
                              model.Filters.Add(
                                  new DisableFormValueModelBindingAttribute());
                          });
    });
            var physicalProvider = new PhysicalFileProvider($"{Directory.GetCurrentDirectory()}/wwwroot/arquivo/video");

            services.AddSingleton<IFileProvider>(physicalProvider);
            services.AddSession();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(t =>
            {
                t.LoginPath = "/Conta/Login";
                t.LogoutPath = "/Conta/Logout";
                t.AccessDeniedPath = "/Erro/Erro403Interno";
                t.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                t.SlidingExpiration = true;
                t.Cookie.HttpOnly = true;
            });
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //services.AddControllersWithViews().AddJsonOptions(x=> x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
            services.AddMvcCore();
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
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Conta}/{action=Login}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default_dois",
                    pattern: "{controller=Conta}/{id?}"
                 );
            });
        }
    }
}
