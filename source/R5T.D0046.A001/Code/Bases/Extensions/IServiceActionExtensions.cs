using System;

using R5T.Suebia;

using R5T.D0046.Default;
using R5T.D0082.D001.I001;
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0046.A001
{
    public static class IServiceActionExtensions
    {
        public static ServiceActionAggregation AddGitAuthenticationProviderServiceActions(this IServiceAction _,
            IServiceAction<ISecretsDirectoryFilePathProvider> secretsDirectoryFilePathProviderAction)
        {
            var gitHubAuthenticationProviderAction = _.AddGitHubAuthenticationProviderAction(
                secretsDirectoryFilePathProviderAction);

            var gitAuthenticationProviderAction = _.AddGitAuthenticationProviderAction(
                gitHubAuthenticationProviderAction);

            var output = new ServiceActionAggregation
            {
                GitAuthenticationProviderAction = gitAuthenticationProviderAction,
                GitHubAuthenticationProviderAction = gitHubAuthenticationProviderAction,
            };

            return output;
        }
    }
}
