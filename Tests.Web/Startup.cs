using Blazored.SessionStorage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Radzen;
using Tests.Database.Context;
using Tests.Database.Infrastructure.CollectionString;
using Tests.Database.Infrastructure.DependencyInjection;
using Tests.Database.ModelIdentity;
using Tests.Logis.Infrastructure.DependencyInjection;
using Tests.Web.Authentication;

namespace Tests.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddBlazoredSessionStorage();

            // blazor.radzen
            services.AddScoped<DialogService>();
            services.AddScoped<NotificationService>();
            services.AddScoped<TooltipService>();
            services.AddScoped<ContextMenuService>();

            // Tests.Logis.Infrastructure.DependencyInjection
            LogicsDependencyInjection.Initialize(services);

            // Tests.Database.Infrastructure.DependencyInjection
            DatabaseDependencyInjection.Initialize(services);

            // Identity
            services.AddAuthentication();
            services.AddAuthorization();
            services.AddIdentity<ApplicationUser, IdentityRole>()
              .AddEntityFrameworkStores<ApplicationIdentityDbContext>();

            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>,
                  ApplicationPrincipalFactory>();

            // ConnectionString db 
            DbContextConnectionString.Initialize(services, Configuration.GetConnectionString("DbUserTests"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationIdentityDbContext identityDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

            identityDbContext.Database.Migrate();
        }
    }
}
