using Microsoft.Bot.Connector.Authentication;
using System.Threading.Tasks;

namespace IdiotBot.Business
{
    public class CustomCredentialProvider : ICredentialProvider
    {
        #region ICredentialProvider

        public Task<string> GetAppPasswordAsync(string appId)
        {
            return Task.Run(() =>
            {
                MockSecretVault.Vault.TryGetValue(appId, out var password);
                return password;
            });
        }

        public Task<bool> IsAuthenticationDisabledAsync()
        {
            return Task.FromResult(false);
        }

        public Task<bool> IsValidAppIdAsync(string appId)
        {
            return Task.FromResult(MockSecretVault.Vault.ContainsKey(appId));
        }

        #endregion
    }
}
