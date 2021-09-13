using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Suebia;


namespace R5T.D0046.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="GitAuthorProvider"/> implementation of <see cref="IGitAuthorProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddGitAuthorProvider(this IServiceCollection services,
            IServiceAction<ISecretsDirectoryFilePathProvider> secretsDirectoryFilePathProviderAction)
        {
            services.AddSingleton<IGitAuthorProvider, GitAuthorProvider>()
                .Run(secretsDirectoryFilePathProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="GitAuthorProvider"/> implementation of <see cref="IGitAuthorProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IGitAuthorProvider> AddGitAuthorProviderAction(this IServiceCollection services,
            IServiceAction<ISecretsDirectoryFilePathProvider> secretsDirectoryFilePathProviderAction)
        {
            var serviceAction = ServiceAction.New<IGitAuthorProvider>(() => services.AddGitAuthorProvider(
                secretsDirectoryFilePathProviderAction));

            return serviceAction;
        }
    }
}