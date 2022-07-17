using Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvisFormationCore.Web.Middlewares
{
    public class RedirectionPermanenteMiddleware
    {
        RequestDelegate _next;
        public RedirectionPermanenteMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, MonDbContext dbContext)
        {

            var path = context.Request.Path.ToUriComponent();
            var entity = dbContext.ReRouting.FirstOrDefault(f => f.OldUrl == path);
            if(entity != null)
            {
                context.Response.Redirect(entity.NewUrl, permanent: true);
                return;
            }

            await _next.Invoke(context);
        }
    }
}
