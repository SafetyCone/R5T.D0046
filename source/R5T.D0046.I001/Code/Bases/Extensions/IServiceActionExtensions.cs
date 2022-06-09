using System;

using R5T.Suebia;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0046.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="GitAuthorProvider"/> implementation of <see cref="IGitAuthorProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IGitAuthorProvider> AddGitAuthorProviderAction(this IServiceAction _,
            IServiceAction<ISecretsDirectoryFilePathProvider> secretsDirectoryFilePathProviderAction)
        {
            var serviceAction = _.New<IGitAuthorProvider>(services => services.AddGitAuthorProvider(
                secretsDirectoryFilePathProviderAction));

            return serviceAction;
        }
    }
}
