//Ejercicio 4 en progreso
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Compact;
using Serilog.Formatting;
using GymManager.ApplicationServices.Members;
using GymManager.ApplicationServices.MembershipTypes;
using GymManager.ApplicationServices.Navigation;
using GymManager.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GymManager.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("Default");

            services.AddDbContext<GymManagerContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                 .AddEntityFrameworkStores<GymManagerContext>();

            services.ConfigureApplicationCookie(options => options.LoginPath = "/Account/LogIn");

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddTransient<IMembersAppServices, MembersAppServices>();

            services.AddTransient<IMenuAppService, MenuAppService>();

            services.AddTransient<IMembershipTypes, MembershipTypesAppServices>();


            // Configuración de Serilog para escribir en un archivo de texto
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Logger(lc => lc.Filter.ByIncludingOnly(evt => evt.Properties.ContainsKey("SourceContext") && evt.Properties["SourceContext"].ToString().Contains("MembersController")))
                .WriteTo.File("Logs/log.txt")
                .CreateLogger();

            // Registrar el servicio de logging
            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.ClearProviders();
                loggingBuilder.AddSerilog(dispose: true);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=AttendanceController}/{action=MemberOut}/{id?}");

            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=AttendanceController}/{action=MemberIn}/{id?}");

            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=MembershipTypesController}/{action=Index}/{id?}");

            });
        }
    }
}
