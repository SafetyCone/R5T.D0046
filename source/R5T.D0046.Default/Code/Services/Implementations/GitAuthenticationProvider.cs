using System;

using System.Threading.Tasks;

using R5T.Aalborg;
using R5T.Dacia;

using R5T.D0082.D001;


namespace R5T.D0046.Default
{
    [ServiceImplementationMarker]
    public class GitAuthenticationProvider : IGitAuthenticationProvider
    {
        private IGitHubAuthenticationProvider GitHubAuthenticationProvider { get; }


        public GitAuthenticationProvider(
            IGitHubAuthenticationProvider gitHubAuthenticationProvider)
        {
            this.GitHubAuthenticationProvider = gitHubAuthenticationProvider;
        }

        public async Task<Authentication> GetGitAuthentication()
        {
            var gitHubAuthentication = await this.GitHubAuthenticationProvider.GetGitHubAuthentication();

            var authentication = new Authentication
            {
                Username = gitHubAuthentication.Username,
                Password = gitHubAuthentication.Password,
            };

            return authentication;
        }
    }
}
