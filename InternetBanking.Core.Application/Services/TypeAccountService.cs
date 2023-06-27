using AutoMapper;
using InternetBanking.Core.Application.Interfaces.Repositories;
using InternetBanking.Core.Application.Interfaces.Services;
using InternetBanking.Core.Application.ViewModels.TypeAccount;
using InternetBanking.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.Core.Application.Services
{
    public class TypeAccountService:GenericServices<SaveTypeAccountVM,TypeAccountVM,TypeAccount>, ITypeAccountService
    {
        private readonly ITypeAccountRepository repo;
        private readonly IMapper mapper;

        public TypeAccountService(ITypeAccountRepository repo, IMapper mapper) : base(repo, mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
    }
}
