using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineTickets.OmniBus.Api.Handlers;
using OnlineTickets.OmniBus.Api.Swagger;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using Services;
using System;
using System.Globalization;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace OnlineTickets.Bus.Api
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
            services.AddEntityFrameworkMySql();
            //services.AddDbContext<Domain.OmnibusDbContext>
            //    (
            //        opt =>
            //            opt.UseMySQL(Configuration.GetConnectionString("DefaultConnection")
            //    ));
            services.AddDbContext<Domain.OmnibusDbContext>(o => o.UseMySql(Configuration.GetConnectionString("DefaultConnection"),
                                                                useMySqlOptions => useMySqlOptions.ServerVersion(new ServerVersion(new Version(8, 0, 18), ServerType.MySql))
                                                                                                  .EnableRetryOnFailure()
            ));

            services.AddTransient<AuthenticateRequestHandler>();

            services.AddLocalization();
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]
                {
                    new CultureInfo("ka-GE"),
                    new CultureInfo("en-US")
                };
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
                options.DefaultRequestCulture = new RequestCulture("en-US");
                options.RequestCultureProviders.Insert(0, new CustomCultureProvider());
            });

            services.AddMvc();

            services.AddSwaggerDocumentation();

            services.AddScoped<IOmnibusService, OmnibusService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwaggerDocumentation();

            //app.UseLoggingRequestHandler();
            //app.UseAPIKeyHandler();

            app.UseRouting();

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
