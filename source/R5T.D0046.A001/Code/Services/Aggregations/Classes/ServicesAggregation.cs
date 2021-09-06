using System;

using R5T.Dacia;


namespace R5T.D0046.A001
{
    public class ServicesAggregation : IServicesAggregation
    {
        public IServiceAction<IGitAuthenticationProvider> GitAuthenticationProviderAction { get; set; }
    }
}
