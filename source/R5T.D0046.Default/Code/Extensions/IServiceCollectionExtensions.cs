using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.D0082.D001;


namespace R5T.D0046.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="GitAuthenticationProvider"/> implementation of <see cref="IGitAuthenticationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddGitAuthenticationProvider(this IServiceCollection services,
            IServiceAction<IGitHubAuthenticationProvider> gitHubAuthenticationProviderAction)
        {
            services
                .AddSingleton<IGitAuthenticationProvider, GitAuthenticationProvider>()
                .Run(gitHubAuthenticationProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="GitAuthenticationProvider"/> implementation of <see cref="IGitAuthenticationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IGitAuthenticationProvider> AddGitAuthenticationProviderAction(this IServiceCollection services,
            IServiceAction<IGitHubAuthenticationProvider> gitHubAuthenticationProviderAction)
        {
            var serviceAction = ServiceAction.New<IGitAuthenticationProvider>(() => services.AddGitAuthenticationProvider(
                gitHubAuthenticationProviderAction));

            return serviceAction;
        }
    }
}
