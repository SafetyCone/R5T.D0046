using System;
using System.Threading.Tasks;

using R5T.T0046;
using R5T.T0064;


namespace R5T.D0046
{
    [ServiceDefinitionMarker]
    public interface IGitAuthorProvider : IServiceDefinition
    {
        Task<Author> GetGitAuthor();
    }
}
