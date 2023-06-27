using InternetBanking.Core.Application.ViewModels.Clients;
using InternetBanking.Core.Application.ViewModels.Clients.Beneficiary;
using InternetBanking.Core.Application.ViewModels.TypeAccount;
using InternetBanking.Core.Domain.Entities;
using System.Threading.Tasks;

namespace InternetBanking.Core.Application.Interfaces.Services
{
    public interface IBeneficiaryServices : IGenericServices<SaveBeneficiaryVM, BeneficiaryVM, Beneficiary>
    {
        Task<SaveBeneficiaryVM> GetByIdSAsync(int id);

    }
}
