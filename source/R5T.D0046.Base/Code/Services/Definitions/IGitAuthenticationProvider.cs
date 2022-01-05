using System;
using System.Threading.Tasks;

using R5T.Aalborg;

using R5T.T0064;


namespace R5T.D0046
{
    [ServiceDefinitionMarker]
    public interface IGitAuthenticationProvider : IServiceDefinition
    {
        Task<Authentication> GetGitAuthentication();
    }
}
