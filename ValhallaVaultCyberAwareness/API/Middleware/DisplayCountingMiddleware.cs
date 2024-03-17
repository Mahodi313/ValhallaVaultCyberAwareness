namespace ValhallaVaultCyberAwareness.API.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public static class DisplayCountingMiddleware
    {
        public static List<string?> MiddlewareLog { get; set; } = new List<string?>();

    }
}
