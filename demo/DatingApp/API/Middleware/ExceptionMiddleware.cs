using System.Net;
using System.Text.Json;
using API.Errors;

namespace API.Middleware;

public class ExceptionMiddleware(
    RequestDelegate next, ILogger<ExceptionMiddleware> logger, IHostEnvironment env)
{

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            // this try any exception that occurs in the whole API, which will bubble up to this
            // point and be caught by the catch block
            await next(context);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            // return a detailed response if we are in development mode
            var response = env.IsDevelopment()
                ? new ApiException(context.Response.StatusCode, ex.Message, ex.StackTrace)
                : new ApiException(context.Response.StatusCode, ex.Message, ex.StackTrace);

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var json = JsonSerializer.Serialize(response, options);

            // return a less detailed response if we are in production - so we can work
            // with it on the client
            await context.Response.WriteAsync(json);


        }
    }

}
