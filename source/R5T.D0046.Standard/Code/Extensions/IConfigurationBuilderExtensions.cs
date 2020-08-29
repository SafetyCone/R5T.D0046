using System;

using Microsoft.Extensions.Configuration;

using R5T.Polidea.Standard;


namespace R5T.D0046.Standard
{
    public static class IConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddGitAuthentication(this IConfigurationBuilder configurationBuilder, IServiceProvider configurationServiceProvider)
        {
            configurationBuilder.AddGitHubAuthenticationConfiguration(configurationServiceProvider);

            return configurationBuilder;
        }
    }
}
