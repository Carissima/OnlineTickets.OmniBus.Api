using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTickets.OmniBus.Api.Handlers
{
    public class CustomCultureProvider : RequestCultureProvider
    {
        public override async Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext context)
        {
            var requestLanguage = context.Request.Headers?["Accept-Language"].FirstOrDefault();
            var defaultLanguage = string.IsNullOrEmpty(requestLanguage) ? "en-GB" : requestLanguage;
            defaultLanguage = defaultLanguage.Contains("en") ? "en-GB" : "ka-GE";

            return await Task.FromResult(new ProviderCultureResult(defaultLanguage, defaultLanguage));
        }
    }
}
