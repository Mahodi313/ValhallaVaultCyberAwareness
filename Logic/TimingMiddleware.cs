using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace ValhallaVaultCyberAwareness.App
{

    /*
     * This middleware calculates how many milliseconds a request takes to complete!
     * OBS: This will only be used in the the main/blazor project but I've created a reusable middleware,
     * so it can be used in other projects in the future!
     * By: Mahdi Ali
     */
    public class TimingMiddleware
    {
        private readonly ILogger<TimingMiddleware> _logger; // Using this to print out info on the console
        private readonly RequestDelegate _next; // Request delegate means the next call

        public TimingMiddleware(ILogger<TimingMiddleware> logger, RequestDelegate next)
        {
            _logger = logger;
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var start = DateTime.UtcNow;
            await _next.Invoke(context);
            _logger.LogInformation($"Request {context.Request.Path}: {(DateTime.UtcNow - start).TotalMicroseconds}ms");

        }
    }
}
