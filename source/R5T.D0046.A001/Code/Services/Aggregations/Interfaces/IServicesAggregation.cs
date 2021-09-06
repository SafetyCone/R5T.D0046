using System;

using R5T.Dacia;


namespace R5T.D0046.A001
{
    public interface IServicesAggregation
    {
        IServiceAction<IGitAuthenticationProvider> GitAuthenticationProviderAction { get; set; }
    }
}
