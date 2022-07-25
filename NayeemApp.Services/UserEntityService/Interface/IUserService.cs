using Microsoft.AspNetCore.Identity;
using NayeemApp.Domain.Entity;

namespace NayeemApp.Services.UserEntityService.Interface
{
    public interface IUserService
    {
        Task<IdentityResult> CreateUser(User model);
        Task<LoginResult> SingIn(Login model);
        Task<User> GetUserProfile(string userId);
        Task<OperationResult<string>> SaveUserInformation(User model);
        Task SignOut();
        Task<OperationResult<string>> ConfirmEmail(string userId, string code);
        Task<OperationResult<string>> ForgotPaswordEmail(string email);
        Task<OperationResult<string>> ResetPassword(ResetPassword model);
        Task<OperationResult<string>> ChangePassword(User model);
    }
}
