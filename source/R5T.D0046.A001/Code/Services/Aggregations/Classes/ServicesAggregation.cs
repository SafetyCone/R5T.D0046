using System;

using R5T.Dacia;

using R5T.D0082.D001;


namespace R5T.D0046.A001
{
    public class ServicesAggregation : IServicesAggregation
    {
        public IServiceAction<IGitAuthenticationProvider> GitAuthenticationProviderAction { get; set; }
        public IServiceAction<IGitHubAuthenticationProvider> GitHubAuthenticationProviderAction { get; set; }
    }
}
