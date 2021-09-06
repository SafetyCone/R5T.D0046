using System;

using R5T.D0046.A001;


namespace System
{
    public static class IServiceAggregationExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceAggregation other)
            where T : IServiceAggregation
        {
            aggregation.GitAuthenticationProviderAction = other.GitAuthenticationProviderAction;
            aggregation.GitHubAuthenticationProviderAction = other.GitHubAuthenticationProviderAction;

            return aggregation;
        }
    }
}
