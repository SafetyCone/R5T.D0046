using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Suebia;

using R5T.D0046.Default;
using R5T.D0082.D001.I001;


namespace R5T.D0046.A001
{
    public static class IServiceCollectionExtension
    {
        public static ServiceAggregation AddGitAuthenticationProviderActions(this IServiceCollection services,
            IServiceAction<ISecretsDirectoryFilePathProvider> secretsDirectoryFilePathProviderAction)
        {
            var gitHubAuthenticationProviderAction = services.AddGitHubAuthenticationProviderAction(
                secretsDirectoryFilePathProviderAction);

            var gitAuthenticationProviderAction = services.AddGitAuthenticationProviderAction(
                gitHubAuthenticationProviderAction);

            return new ServiceAggregation
            {
                GitAuthenticationProviderAction = gitAuthenticationProviderAction,
                GitHubAuthenticationProviderAction = gitHubAuthenticationProviderAction,
            };
        }
    }
}
