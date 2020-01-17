using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace OnlineTickets.OmniBus.Api.Handlers
{
    public class IpRequestHandler : DelegatingHandler
    {
        string[] IpAddress = {
            "176.221.137.22", //office
            "127.0.0.1",
            "::1",
            "212.58.120.208" //tiko
        };
        private readonly RequestDelegate _next;
        public IpRequestHandler(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            if (!IpAddress.Contains(context.Connection.RemoteIpAddress.ToString()))
            {
                context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                await context.Response.WriteAsync("Access Denied!");
            }
            await _next.Invoke(context);
        }
    }
    public static class IpAuthorizationHandlerExtensions
    {
        public static IApplicationBuilder UseIpHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<IpRequestHandler>();
        }
    }
}
