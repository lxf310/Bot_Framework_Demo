using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Integration.AspNet.WebApi;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace IdiotBot.Api.Controllers
{
    public class MessagesController : ApiController
    {
        #region Properties

        private readonly IBotFrameworkHttpAdapter _adapter;
        private readonly IBot _bot;

        #endregion


        #region Constructors

        public MessagesController(IBotFrameworkHttpAdapter adapter, IBot bot)
        {
            _adapter = adapter;
            _bot = bot;
        }

        #endregion


        #region Methods

        [HttpPost]
        public async Task<HttpResponseMessage> PostAsync()
        {
            var response = new HttpResponseMessage();
            await _adapter.ProcessAsync(Request, response, _bot);
            return response;
        }


        [HttpGet]
        public string GetInfo()
        {
            return "Hello";
        }

        #endregion
    }
}