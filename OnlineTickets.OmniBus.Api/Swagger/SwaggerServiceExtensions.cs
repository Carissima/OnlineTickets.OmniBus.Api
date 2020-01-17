using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.Collections.Generic;
using System.IO;

namespace OnlineTickets.OmniBus.Api.Swagger
{
    public static class SwaggerServiceExtensions
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.OperationFilter<AcceptLanguageParameter>();
                c.CustomSchemaIds(obj => obj.FullName);
                c.SwaggerDoc("v1",
                    new OpenApiInfo()
                    {
                        Title = "OnlineTickets OmniBus Api",
                        Version = "v1",
                        Contact = new OpenApiContact { Email = "support@lemondo.com", Url = new Uri("http://lemondo.com/"), Name = "Lemondo" },
                        Description = "OnlineTickets OmniBus Api Documentation"
                    }
                );
                var security = new OpenApiSecurityRequirement
                {
                    {new OpenApiSecurityScheme
                    {
                        Type = SecuritySchemeType.ApiKey,
                        In = ParameterLocation.Header,
                        Reference = new OpenApiReference(){Type = ReferenceType.SecurityScheme, Id ="Bearer"}
                    }, new List<string>() }
                };

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "APIKey",
                    In = ParameterLocation.Header,
                    Scheme = "apiKey"
                });

                c.AddSecurityRequirement(security);
            });
            services.ConfigureSwaggerGen(options =>
            {
                //options.CustomSchemaIds(x => x.FullName);
                var xmlDocFile = Path.Combine(AppContext.BaseDirectory, Environment.CurrentDirectory + @"\OnlineTickets.Fly.Api.xml");
                if (File.Exists(xmlDocFile))
                {
                    options.IncludeXmlComments(xmlDocFile);
                }
            });
            return services;
        }

        public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Versioned API v1.0");
                c.DocExpansion(DocExpansion.None);
                c.RoutePrefix = string.Empty;

            });
            return app;
        }
    }
}
