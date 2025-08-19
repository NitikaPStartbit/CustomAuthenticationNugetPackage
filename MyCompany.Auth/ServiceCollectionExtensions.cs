using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace MyCompany.Auth
{
    public static class ServiceCollectionExtensions
    {
        public static AuthenticationBuilder AddBasicAuthentication(this IServiceCollection services)
        {
            return services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
        }
    }
}
