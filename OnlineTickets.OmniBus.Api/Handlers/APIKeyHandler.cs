using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace OnlineTickets.OmniBus.Api.Handlers
{
    public class ApiKeyHandler : DelegatingHandler
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;
        public ApiKeyHandler(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }
        public async Task Invoke(HttpContext context)
        {
            // var lang = CultureInfo.CurrentCulture.Name.Split('-')[0];
            var apiKey = _configuration.GetSection("Auth:ApiKey").Value ??
                      throw new ArgumentNullException("Auth:ApiKey", "apikey not set in appsettings.json");
            bool validKey = false;
            var checkApiKey = context.Request.Headers.ContainsKey("ApiKey");
            if (checkApiKey)
            {
                if (context.Request.Headers["ApiKey"].Equals(apiKey))
                {
                    validKey = true;
                }
            }
            if (!validKey)
            {
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                await context.Response.WriteAsync("Unauthorized");
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
    public static class AuthorizationHandlerExtensions
    {
        public static IApplicationBuilder UseAPIKeyHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ApiKeyHandler>();
        }
    }
}
