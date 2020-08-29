using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Polidea;
using R5T.Polidea.Standard;

using R5T.D0046.Default;


namespace R5T.D0046.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IGitAuthenticationProvider"/> service.
        /// </summary>
        public static IServiceCollection AddGitAuthenticationProvider(this IServiceCollection services)
        {
            var gitAuthenticationProviderAction = services.AddGitAuthenticationProviderAction();

            services
                .Run(gitAuthenticationProviderAction.Main)
                .Run(gitAuthenticationProviderAction.gitHubAuthenticationProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IGitAuthenticationProvider"/> service.
        /// </summary>
        public static
            (
            IServiceAction<IGitAuthenticationProvider> Main,
            IServiceAction<IGitHubAuthenticationProvider> gitHubAuthenticationProviderAction
            )
        AddGitAuthenticationProviderAction(this IServiceCollection services)
        {
            var gitHubAuthenticationProviderAction = services.AddGitHubAuthenticationProviderAction();

            var gitAuthenticationProviderAction = services.AddGitAuthenticationProviderAction(
                gitHubAuthenticationProviderAction);

            return
            (
                gitAuthenticationProviderAction,
                gitHubAuthenticationProviderAction
            );
        }
    }
}
