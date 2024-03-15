﻿using ValhallaVaultCyberAwareness.DAL.Data.MiddlewareModel;
using ValhallaVaultCyberAwareness.Data;

namespace ValhallaVaultCyberAwareness.API.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CountingMiddleware
    {
        private readonly RequestDelegate _next;


        public CountingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, ApplicationDbContext dbContext)
        {

            if (httpContext.Request.Path.StartsWithSegments("/api/Category/GetAllCategoriesAndMetadata"))
            {
                CountMiddlewareModel? count = dbContext.Counts.FirstOrDefault(c => c.Type == "GetAllCategoriesAndMetadata");
                if (count == null)
                {
                    count = new CountMiddlewareModel { Count = 1, Type = "GetAllCategoriesAndMetadata" };
                    dbContext.Counts.AddAsync(count);

                }
                else
                {
                    count.Count++;
                    Console.WriteLine($"GetAllCategoriesAndMetadata - has been called a total number of {count.Count} times!");
                }

                await dbContext.SaveChangesAsync();
            }

            if (httpContext.Request.Path.StartsWithSegments("/api/Category/GetAllCategories"))
            {
                CountMiddlewareModel? count = dbContext.Counts.FirstOrDefault(c => c.Type == "GetAllCategories");
                if (count == null)
                {
                    count = new CountMiddlewareModel { Count = 1, Type = "GetAllCategories" };
                    dbContext.Counts.AddAsync(count);

                    Console.WriteLine($"GetAllCategories - has been called a total number of {count.Count} times!");
                }
                else
                {
                    count.Count++;

                    Console.WriteLine($"GetAllCategories - has been called a total number of {count.Count} times!");
                }

                await dbContext.SaveChangesAsync();
            }

            if (httpContext.Request.Path.StartsWithSegments("/api/Category/GetCategoryById"))
            {
                CountMiddlewareModel? count = dbContext.Counts.FirstOrDefault(c => c.Type == "GetCategoryById");
                if (count == null)
                {
                    count = new CountMiddlewareModel { Count = 1, Type = "GetCategoryById" };
                    dbContext.Counts.Add(count);

                    Console.WriteLine($"GetCategoryById - has been called a total number of {count.Count} times!");
                }
                else
                {
                    count.Count++;

                    Console.WriteLine($"GetCategoryById - has been called a total number of {count.Count} times!");
                }

                await dbContext.SaveChangesAsync();
            }


            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CountingMiddlewareExtensions
    {
        public static IApplicationBuilder UseCountingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CountingMiddleware>();
        }
    }
}
