using System;

using R5T.Dacia;

using R5T.D0082.D001;


namespace R5T.D0046.A001
{
    public interface IServiceAggregation
    {
        IServiceAction<IGitAuthenticationProvider> GitAuthenticationProviderAction { get; set; }
        IServiceAction<IGitHubAuthenticationProvider> GitHubAuthenticationProviderAction { get; set; }
    }
}
