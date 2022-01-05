using System;

using R5T.D0046.A001;


namespace System
{
    public static class IServiceActionAggregationExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceActionAggregation other)
            where T : IServiceActionAggregation
        {
            aggregation.GitAuthenticationProviderAction = other.GitAuthenticationProviderAction;
            aggregation.GitHubAuthenticationProviderAction = other.GitHubAuthenticationProviderAction;

            return aggregation;
        }
    }
}
