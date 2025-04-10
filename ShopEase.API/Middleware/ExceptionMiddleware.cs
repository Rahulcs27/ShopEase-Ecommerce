using ShopEase.Application.Exceptions;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json;

namespace ShopEase.API.Middleware
{
    public class ExceptionMiddleware
    {
        readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext httpContext, Exception ex)
        {
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
            string errorMessage = "An unexpected error occurred.";
            var innerMessage = ex.InnerException?.Message;

            switch (ex)
            {
                case ValidationException validationEx:
                    statusCode = HttpStatusCode.BadRequest;
                    errorMessage = validationEx.Message;
                    break;
                default:
                    statusCode = HttpStatusCode.InternalServerError;
                    errorMessage = ex.Message;
                    break;
            }

            httpContext.Response.StatusCode = (int)statusCode;
            httpContext.Response.ContentType = "application/json";

            var response = new
            {
                StatusCode = (int)statusCode,
                Message = errorMessage,
                InnerException = innerMessage

            };

            var jsonResponse = JsonSerializer.Serialize(response);
            await httpContext.Response.WriteAsync(jsonResponse);
        }
    }
}
