using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineTickets.OmniBus.Api.Handlers
{
    public class AuthenticateRequestHandler : DelegatingHandler
    {
        private readonly IConfiguration _configuration;
        public AuthenticateRequestHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancelationToken)
        {
            var authCode = _configuration.GetSection("Auth:AuthCode").Value ?? throw new ArgumentNullException("Auth:AuthCode", "Authentication Code is not set in 'appsettings.json'");
            var newUri = string.Format(request.RequestUri.OriginalString, authCode);
            request.RequestUri = new Uri(newUri);
            return await base.SendAsync(request, cancelationToken);
        }
    }
}
