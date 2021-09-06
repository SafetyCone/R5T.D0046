using System;

using R5T.D0046.A001;


namespace System
{
    public static class IServicesAggregationExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServicesAggregation other)
            where T : IServicesAggregation
        {
            aggregation.GitAuthenticationProviderAction = other.GitAuthenticationProviderAction;
            aggregation.GitHubAuthenticationProviderAction = other.GitHubAuthenticationProviderAction;

            return aggregation;
        }
    }
}
