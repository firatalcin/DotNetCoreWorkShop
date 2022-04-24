using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace AspNetCoreCS.Middlewares
{
    public class RequestEditingMiddleware
    {
        RequestDelegate _requestDelegate;

        public RequestEditingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.ToString() == "/firat")
                await context.Response.WriteAsync("Hosgeldin Firat");
            else
                await _requestDelegate.Invoke(context);
        }
    }
}
