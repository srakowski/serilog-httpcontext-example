using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog.Context;

namespace LoggingExample
{
    public class RemoteIpAddressLoggingMiddleware  
    {
        private readonly RequestDelegate _next;

        public RemoteIpAddressLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            using (LogContext.PushProperty("Address", context.Connection.RemoteIpAddress))
            {
                await _next.Invoke(context);
            }
        }
    }
}

