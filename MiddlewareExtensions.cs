using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoggingExample
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseRemoteIpAddressLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RemoteIpAddressLoggingMiddleware>();
        }
    }
}