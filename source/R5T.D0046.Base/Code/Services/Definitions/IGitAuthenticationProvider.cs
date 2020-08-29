using System;
using System.Threading.Tasks;

using R5T.Aalborg;


namespace R5T.D0046
{
    public interface IGitAuthenticationProvider
    {
        Task<Authentication> GetGitAuthentication();
    }
}
