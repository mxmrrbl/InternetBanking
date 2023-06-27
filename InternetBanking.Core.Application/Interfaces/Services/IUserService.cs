using InternetBanking.Core.Application.Dtos.Account;
using InternetBanking.Core.Application.ViewModels.Users;
using InternetBanking.Core.Application.ViewModels.Users.Client;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InternetBanking.Core.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<string> ConfirmEmailAsync(string userId, string token);
        Task<ForgotPassWordResponse> ForgotPasswordAsync(ForgotPasswordVM vm, string origin);
        Task<AuthenticationResponse> LoginAsync(LoginVM vm);
        Task<RegisterResponse> RegisterAsync(SaveUserVM vm,string origin);
        Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordVM vm);
        Task<List<UserVM>> GetAllUsersAsync();
        Task<List<UserVM>> GetAllClientsAsync();
        Task<UserVM> GetUserByIdAsync(string id);
        Task<SaveClienteVM>GetSaveClientVMByIdAsync(string id);
        Task<SaveUserVM> GetSaveUserVMByIdAsync(string id);
        Task<AuthenticationResponse> IsVerified(string id);
        Task<RegisterResponse> UpdateUserAsync(SaveUserVM vm);
        Task SignOutAsync();
    }
}