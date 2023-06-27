using InternetBanking.Core.Application.Dtos.Account;
using InternetBanking.Core.Application.helper;
using InternetBanking.Core.Application.ViewModels.Users;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppl.InternetBanking.middlewares
{
    public class ValidSession
    {
        private readonly IHttpContextAccessor _context;

        public ValidSession(IHttpContextAccessor context)
        {
            _context = context;
        }
        public bool HasUser()
        {
            AuthenticationResponse user = _context.HttpContext.Session.Get<AuthenticationResponse>("user");

            if (user == null)
            {
                return false;
            }

            return true;
        }
    }
}
