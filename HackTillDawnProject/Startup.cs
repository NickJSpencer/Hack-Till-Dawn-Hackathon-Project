using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HackTillDawnProject.Data;
using HackTillDawnProject.Models;
using HackTillDawnProject.Services;
using HackTillDawnProject.ModelManager;
using Amazon.Extensions.NETCore.Setup;
using Amazon.Runtime.CredentialManagement;
using Amazon;
using Amazon.S3;

namespace HackTillDawnProject
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("awsdb")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
            

            //AWS
            services.AddDefaultAWSOptions(Configuration.GetAWSOptions());
            services.AddAWSService<IAmazonS3>();
            services.AddScoped<IAWSService, AWSService>();

            //Database Services
            services.AddScoped<IAPIResultTypeService, APIResultTypeService>();
            services.AddScoped<IChannelContactService, ChannelContactService>();
            services.AddScoped<IChannelService, ChannelService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IDeviceEventIntermediateService, DeviceEventIntermediateService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IFootageStorageService, FootageStorageService>();
            services.AddScoped<IRegisteredDeviceService, RegisteredDeviceService>();
            services.AddScoped<IStaffEventIntermediateService, StaffEventIntermediateService>();

            //Managers
            services.AddScoped<FootageManager>();

            services.AddTransient<IEmailSender, EmailSender>();
            



            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
