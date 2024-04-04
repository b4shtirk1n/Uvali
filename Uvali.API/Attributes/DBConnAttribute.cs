using Microsoft.AspNetCore.Mvc.Filters;
using Uvali.API.Constants;
using Uvali.API.Models;

namespace Uvali.API.Attribute
{
    public class DBConnAttribute(
        ILogger<DBConnAttribute> logger,
        UvaliDBContext context
    ) : IAsyncAuthorizationFilter
    {
        private readonly ILogger<DBConnAttribute> logger = logger;
        private readonly UvaliDBContext context = context;

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            if (!await this.context.Database.CanConnectAsync())
            {
                logger.LogError("db conn error");
                context.Result = Error.DB_CONNECTION_FAILED;
            }
        }
    }
}