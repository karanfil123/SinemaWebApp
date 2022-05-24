using Microsoft.AspNetCore.Diagnostics;
using Sinemam.Core.Dtos;
using Sinemam.Service.Exceptions;
using System.Text.Json;

namespace Sinemam.WebAPI.Middleware
{
    public static class UseCustomExceptionHandler
    {
        public static void UseCustomException(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.ContentType = "application/json";
                    var exceptionFuture = context.Features.Get<IExceptionHandlerFeature>();
                    var statusCode = exceptionFuture.Error switch
                    {
                        ClientSideException => 400,
                        NotFoundException => 404,
                        _ => 500
                    };
                    context.Response.StatusCode = statusCode;
                    var response = CustomResponseDto<NoContentDto>.Failed(statusCode, exceptionFuture.Error.Message);
                    await context.Response.WriteAsync(JsonSerializer.Serialize(response));
                });
            });
        }
    }
}
