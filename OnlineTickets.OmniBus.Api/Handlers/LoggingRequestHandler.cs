//using System;
//using System.IO;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Http;
//using Serilog;

//namespace OnlineTickets.OmniBus.Api.Handlers
//{
//    public class RequestResponseLoggingMiddleware
//    {
//        private readonly RequestDelegate _next;

//        public RequestResponseLoggingMiddleware(RequestDelegate next)
//        {
//            _next = next;
//        }

//        public async Task Invoke(HttpContext context)
//        {
//            //Skip flight-search results caching because of heavy objects
//            if (context.Request.Path.Value.Contains("flight-search"))
//            {
//                await _next(context);
//                return;
//            }

//            var request = await FormatRequest(context.Request);
//            var originalBodyStream = context.Response.Body;

//            using (var responseBody = new MemoryStream())
//            {
//                context.Response.Body = responseBody;
//                await _next(context);
//                var response = await FormatResponse(context.Response);

//                //TODO: LOGGING update data to save
//                Log.ForContext("Environment", Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"))
//                    .ForContext("CallName", context.Request.Path.ToString())
//                    //.ForContext("RequestHeader", JsonConvert.SerializeObject(context.Request.Headers.GetEnumerator()))
//                    .ForContext("RequestBody", request)
//                    .ForContext("ResponseBody", response)
//                    //.ForContext("RequestTimeStamp", DateTime.UtcNow)
//                    .Information("");

//                //Copy the contents of the new memory stream (which contains the response) to the original stream, which is then returned to the client.
//                await responseBody.CopyToAsync(originalBodyStream);
//            }
//        }

//        private async Task<string> FormatRequest(HttpRequest request)
//        {
//            request.EnableBuffering();

//            var buffer = new byte[Convert.ToInt32(request.ContentLength)];

//            await request.Body.ReadAsync(buffer, 0, buffer.Length); ;

//            var bodyAsText = Encoding.UTF8.GetString(buffer);

//            request.Body.Position = 0;

//            return $"{request.Scheme} {request.Host}{request.Path} {request.QueryString} {bodyAsText}";
//        }

//        private async Task<string> FormatResponse(HttpResponse response)
//        {
//            response.Body.Seek(0, SeekOrigin.Begin);
//            string text = await new StreamReader(response.Body).ReadToEndAsync();
//            response.Body.Seek(0, SeekOrigin.Begin);
//            return $"{response.StatusCode}: {text}";
//        }
//    }

//    public static class LoggingHandlerExtensions
//    {
//        public static IApplicationBuilder UseLoggingRequestHandler(this IApplicationBuilder builder)
//        {
//            return builder.UseMiddleware<RequestResponseLoggingMiddleware>();
//        }
//    }

//}