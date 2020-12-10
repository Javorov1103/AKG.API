namespace AutoService.API.Infrastructure.Services
{
    using AutoService.API.Data;
    using Microsoft.AspNetCore.Http;

    public class CurrentUserService : ICurrentUserService
    {
        private readonly User user;
        private readonly IHttpContextAccessor httpContextAccessor;
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            this.user = (User)httpContextAccessor.HttpContext?.Items["User"];
            this.httpContextAccessor = httpContextAccessor;
        }
        

        public int GetCompanyId()
        => this.user.CompanyId;

        public int GetId()
            => user.Id;

        public string GetUserName()
            => this.user.UserName;

        public void SetUser(User user)
        {
            this.httpContextAccessor.HttpContext.Items["User"] = user;
        }
    }
}
