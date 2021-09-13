using System;
using System.Threading.Tasks;

using R5T.T0046;


namespace R5T.D0046
{
    public interface IGitAuthorProvider
    {
        Task<Author> GetGitAuthor();
    }
}
