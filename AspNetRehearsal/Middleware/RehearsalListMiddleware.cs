using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetRehearsal.Middleware;

    public class RehearsalListMiddleware
    {
        private RequestDelegate next;
        public RehearsalListMiddleware(RequestDelegate nextDelegate)
        {
            next = nextDelegate;
        }

        public async Task Invoke(HttpContext context){
            if(context.Request.Method == HttpMethods.Get){
                await context.Response.WriteAsync("Kek '/n'");
                await next(context);
            }
        } 
    }

    public class TestMiddleware {
        private RequestDelegate next;
        public TestMiddleware (RequestDelegate nextDelegate)
        {
            next = nextDelegate;
        }

        public async Task Invoke(HttpContext context){
            if(context.Request.Method == HttpMethods.Get) {
                await context.Response.WriteAsync("test kek");

            }
        }
    }
    
