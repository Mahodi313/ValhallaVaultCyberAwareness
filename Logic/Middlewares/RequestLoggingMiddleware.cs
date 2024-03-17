using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace ValhallaVaultCyberAwareness.App.Middlewares
{
    /// <summary>
    /// Middleware for logging HTTP requests.
    /// This middleware logs each incoming HTTP request method and path to help with debugging and monitoring.
    /// </summary>
    /// <remarks>
    /// By: Rida Abdal
    /// This class is part of the ValhallaVaultCyberAwareness application's middlewares.
    /// It is intended to be used as part of the HTTP request processing pipeline to log
    /// information about each request, such as the HTTP method and the requested path.
    /// The logging is performed at the 'Information' level, which can be adjusted
    /// in the application settings if a different level of detail is required.
    /// </remarks>
    public class RequestLoggingMiddleware
    {

        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestLoggingMiddleware"/> class.
        /// </summary>
        /// <param name="next">The next middleware delegate in the HTTP pipeline to be called.</param>
        /// <param name="logger">The logger used for logging information about the requests.</param>
        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        /// <summary>
        /// Invokes the middleware with the given HTTP context.
        /// </summary>
        /// <param name="context">The <see cref="HttpContext"/> for the current request.</param>
        /// <returns>A task that represents the completion of request processing.</returns>
        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogInformation($"Handling request: {context.Request.Method} {context.Request.Path}");

            await _next(context);
        }
    }
}
