﻿using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0082.D001;
using R5T.T0063;


namespace R5T.D0046.Default
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="GitAuthenticationProvider"/> implementation of <see cref="IGitAuthenticationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddGitAuthenticationProvider(this IServiceCollection services,
            IServiceAction<IGitHubAuthenticationProvider> gitHubAuthenticationProviderAction)
        {
            services
                .AddSingleton<IGitAuthenticationProvider, GitAuthenticationProvider>()
                .Run(gitHubAuthenticationProviderAction)
                ;

            return services;
        }
    }
}
