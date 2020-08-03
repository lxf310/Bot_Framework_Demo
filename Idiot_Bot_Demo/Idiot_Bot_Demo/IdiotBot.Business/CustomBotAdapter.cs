using Microsoft.Bot.Builder.Integration.AspNet.WebApi;
using Microsoft.Bot.Connector.Authentication;

namespace IdiotBot.Business
{
    public class CustomBotAdapter : BotFrameworkHttpAdapter
    {
        #region Constructor

        public CustomBotAdapter(ICredentialProvider provider) : base(provider)
        {
        }

        #endregion
    }
}
