using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Bfl.Netflix_Tv.Filters.AuthorizationFilters
{
    public class Authorize : Attribute, IFilterFactory
    {
        public bool IsReusable => false;
        private readonly string[]? Roles;
        public Authorize(params string[] Roles)
        {
            this.Roles = Roles;
        }

        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider)
        {
            var filter = serviceProvider.GetRequiredService<RoleValidationAuthorizationFilter>();
            filter.Roles=Roles;
            return filter;
        }
    }
    public class RoleValidationAuthorizationFilter : IAsyncAuthorizationFilter
    {
        public  string[]? Roles { get; set; }
        public Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            var h = true;
            Console.WriteLine(Roles[0], Roles[1], Roles[2]);
           return Task.CompletedTask;
        }
    }
}
