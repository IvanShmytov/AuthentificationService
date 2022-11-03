using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace AuthentificationService
{
    public class LogMiddleware
    {
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;

        public LogMiddleware(RequestDelegate next, ILogger logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            _logger.WriteEvent("Я твой Middleware");           
            _logger.WriteEvent(httpContext.Request.HttpContext.Connection.RemoteIpAddress.ToString());
            await _next(httpContext);
        }
    }
}
