using InternetBanking.Core.Application.ViewModels.TypeAccount;
using InternetBanking.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.Core.Application.Interfaces.Services
{
    public interface ITypeAccountService : IGenericServices<SaveTypeAccountVM, TypeAccountVM, TypeAccount>
    {
    }
}
