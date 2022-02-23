using Microsoft.AspNetCore.Authorization;

namespace Rookies.Backend.Security.Authorization.Requirements
{
    public class AdminRoleRequirement : IAuthorizationRequirement
    {
        public AdminRoleRequirement() {}
    }
}
