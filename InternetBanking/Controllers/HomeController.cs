using InternetBanking.Core.Application.Dtos.Account;
using InternetBanking.Core.Application.helper;
using InternetBanking.Core.Application.Interfaces.Services;
using InternetBanking.Core.Application.ViewModels.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppl.InternetBanking.middlewares;
using WebAppl.InternetBanking.Models;

namespace WebAppl.InternetBanking.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ITrasantionalService service;
        private readonly IProductServices Productservice;
        private readonly IHttpContextAccessor context;
        AuthenticationResponse user;

        public HomeController(ITrasantionalService service, IProductServices Productservice, IHttpContextAccessor _context)
        {
            this.service = service;
            this.Productservice = Productservice;
            context = _context;
            user = context.HttpContext.Session.Get<AuthenticationResponse>("user");
        }

        [ServiceFilter(typeof(SelectHome))]
        public IActionResult Index()
        {
         
            return View();
        }
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> IndexAdmin()
        {
           
            var items = await service.GetTransationalToday();
            return View("IndexAdmin",items);
        }

        [Authorize(Roles ="Basic")]
        public async Task<IActionResult> IndexClient()
        {
         
            var item = await Productservice.GetAllWithIncludeAsync();
            item = item.Where(pr => pr.IdClient == user.Id).ToList();
            return View("IndexClient",item);
        }

    }
}
