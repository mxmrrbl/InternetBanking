using InternetBanking.Core.Application.Dtos.Account;
using InternetBanking.Core.Application.helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppl.InternetBanking.Controllers;

namespace WebAppl.InternetBanking.middlewares
{
    public class SelectHome: IAsyncActionFilter
    {
        private readonly IHttpContextAccessor _httpContext;
        private readonly AuthenticationResponse user;
        public SelectHome(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
            user = _httpContext.HttpContext.Session.Get<AuthenticationResponse>("user");
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (user.Roles.Count > 1)
            {
                await next();
            }

            if (user.Roles.Any(r => r == "Basic"))
            {
                var controller = (HomeController)context.Controller;
                context.Result = controller.RedirectToAction("IndexClient", "home");
            }

            if (user.Roles.Any(r=>r == "Admin"))
            {
                var controller = (HomeController)context.Controller;
                context.Result = controller.RedirectToAction("IndexAdmin", "home");
            }            
        }
    }
}

