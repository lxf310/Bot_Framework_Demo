using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace IdiotBot.Business
{
    public class HelloBot : ActivityHandler
    {
        #region Methods

        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var incomingMsg = turnContext.Activity.Text?.Trim().ToLowerInvariant();
            string reply;
            if (string.IsNullOrWhiteSpace(incomingMsg) || incomingMsg == "hello" || incomingMsg == "hi")
            {
                reply = $"Nice to meet you, {turnContext.Activity.From.Name}!";
            }
            else if (incomingMsg == "date")
            {
                reply = DateTime.Now.ToString("yyyy-MM-dd");
            }
            else if (incomingMsg == "time")
            {
                reply = DateTime.Now.ToString("HH:mm:ss");
            }
            else if (incomingMsg == "lucky number")
            {
                reply = new Random(35).Next().ToString();
            }
            else
            {
                reply = "Please try out date/time/lucky number.";
            }
            await turnContext.SendActivityAsync(MessageFactory.Text(reply), cancellationToken);
        }

        #endregion
    }
}
