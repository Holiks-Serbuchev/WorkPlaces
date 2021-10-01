using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WorkPlaces
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
            services.AddTransient<Repository.Login.ILoginRepository, Repository.Login.LoginRepository>();
            services.AddTransient<Repository.Register.IRegisterRepository, Repository.Register.RegisterRepository>();
            services.AddTransient<Repository.Roles.IRolesRepository, Repository.Roles.RolesRepository>();
            services.AddTransient<Repository.Devices.IDevicesRepository, Repository.Devices.DevicesRepository>();
            services.AddTransient<Repository.Main.IMainRepository, Repository.Main.MainRepository>();
            services.AddTransient<Repository.Table.ITableRepository, Repository.Table.TableRepository>();
            ///////
            services.AddTransient<Service.Login.ILoginService, Service.Login.LoginService>();
            services.AddTransient<Service.Register.IRegisterService, Service.Register.RegisterService>();
            services.AddTransient<Service.Roles.IRolesService, Service.Roles.RolesService>();
            services.AddTransient<Service.Devices.IDevicesService, Service.Devices.DevicesService>();
            services.AddTransient<Service.Main.IMainService, Service.Main.MainService>();
            services.AddTransient<Service.Table.ITableService, Service.Table.TableService>();
            services.AddControllersWithViews();
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
