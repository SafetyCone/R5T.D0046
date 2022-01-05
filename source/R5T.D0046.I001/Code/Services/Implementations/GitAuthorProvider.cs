using System;
using System.Threading.Tasks;

using Newtonsoft.Json;

using R5T.Suebia;

using R5T.T0046;
using R5T.T0064;


namespace R5T.D0046.I001
{
    [ServiceImplementationMarker]
    public class GitAuthorProvider : IGitAuthorProvider, IServiceImplementation
    {
        private ISecretsDirectoryFilePathProvider SecretsDirectoryFilePathProvider { get; }


        public GitAuthorProvider(
            ISecretsDirectoryFilePathProvider secretsDirectoryFilePathProvider)
        {
            this.SecretsDirectoryFilePathProvider = secretsDirectoryFilePathProvider;
        }

        public async Task<Author> GetGitAuthor()
        {
            var authorJsonFilePath = await this.SecretsDirectoryFilePathProvider.GetSecretsFilePath(
                Instances.FileName.GitHubAuthorJson());

            var author = await JsonFileHelper.LoadFromFile<Author>(
                authorJsonFilePath,
                "GitHubAuthor");

            return author;
        }
    }
}