namespace SchoolManagementAPI.Services.Auth
{
    public interface IAuthService
    {
        Task<bool> Register(string username, string password);
        Task<bool> Login(string username, string password);
        Task<bool> ChangePassword(string oldPassword, string newPassword);
        Task<bool> DeleteAccount();
        Task<bool> Logout();
    }
}
