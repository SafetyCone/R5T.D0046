using System;
using System.Threading.Tasks;

using R5T.Aalborg;
using R5T.Dacia;


namespace R5T.D0046
{
    [ServiceDefinitionMarker]
    public interface IGitAuthenticationProvider
    {
        Task<Authentication> GetGitAuthentication();
    }
}
