using System;

using R5T.D0082.D001;
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0046.Default
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="GitAuthenticationProvider"/> implementation of <see cref="IGitAuthenticationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IGitAuthenticationProvider> AddGitAuthenticationProviderAction(this IServiceAction _,
            IServiceAction<IGitHubAuthenticationProvider> gitHubAuthenticationProviderAction)
        {
            var serviceAction = _.New<IGitAuthenticationProvider>(services => services.AddGitAuthenticationProvider(
                gitHubAuthenticationProviderAction));

            return serviceAction;
        }
    }
}
