using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Suebia;

using R5T.T0063;


namespace R5T.D0046.I001
{
    public static partial class IServiceCollectionExtensions
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
    }
}