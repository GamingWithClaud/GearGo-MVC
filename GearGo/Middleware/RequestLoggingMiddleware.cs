using System.Globalization;

namespace GearGo.Middleware
{
    // dont know how half this shit works it works dont touche please :)
    public class RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
    {
        private readonly RequestDelegate _next = next;
        private readonly ILogger<RequestLoggingMiddleware> _logger = logger;

        public async Task InvokeAsync(HttpContext context)
        {
            // Log safe request metadata only. Do not include headers, body or query strings,
            // since they may contain passwords, tokens or other sensitive values.
            var now = DateTime.UtcNow.ToString("o", CultureInfo.InvariantCulture);
            var method = context.Request.Method;
            var path = context.Request.Path;

            _logger.LogInformation("[{Now}] HTTP {Method} {Path}", now, method, path);

            // Pass the request to the next middleware or endpoint in the pipeline.
            await _next(context);
        }
    }
}