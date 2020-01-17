using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;

namespace OnlineTickets.OmniBus.Api.Swagger
{
    public class AcceptLanguageParameter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();
            operation.Parameters.Add(new OpenApiParameter()
            {
                Name = "Accept-Language",
                In = ParameterLocation.Header,
                Schema = new OpenApiSchema()
                {
                    Type = "String",
                    Default = new OpenApiString("en-US")
                },
                Required = false,
            });
        }

    }
}
