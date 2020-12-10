namespace AutoService.API.Infrastructure.Services
{
    using AutoService.API.Data;

    public interface ICurrentUserService
    {
        string GetUserName();

        int GetId();

        int GetCompanyId();

        void SetUser(User user);
    }
}
