﻿using System;

using R5T.D0082.D001;
using R5T.T0063;


namespace R5T.D0046.A001
{
    public interface IServiceActionAggregation
    {
        IServiceAction<IGitAuthenticationProvider> GitAuthenticationProviderAction { get; set; }
        IServiceAction<IGitHubAuthenticationProvider> GitHubAuthenticationProviderAction { get; set; }
    }
}
