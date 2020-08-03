using IdiotBot.Business;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Integration.AspNet.WebApi;
using Microsoft.Bot.Connector.Authentication;
using Unity;

namespace IdiotBot.Api.App_Start
{
    public class UnityConfig
    {
        #region Methods

        public static IUnityContainer GetConfiguredContainer()
        {
            var _container = new UnityContainer();
            RegisterTypes(_container);
            return _container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<ICredentialProvider, CustomCredentialProvider>();
            container.RegisterType<IBot, HelloBot>();
            container.RegisterType<IBotFrameworkHttpAdapter, CustomBotAdapter>();
        }

        #endregion
    }
}