// Generated with EchoBot .NET Template version v4.22.0

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MeuChatBot.Services;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace EchoBot.Bots
{
    public class EchoBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var userMessage = turnContext.Activity.Text;
            string resposta;

            try
            {
                // Chama o serviço que se comunica com o modelo Mistral no LM Studio
                var mistral = new MistralService();
                resposta = await mistral.GetResponseAsync(userMessage);
            }
            catch
            {
                resposta = "Desculpe, estou enfrentando problemas para me conectar ao serviço de IA no momento.";
            }

            // Envia a resposta do modelo de volta ao usuário
            await turnContext.SendActivityAsync(MessageFactory.Text(resposta), cancellationToken);
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            var welcomeText = "Olá! Eu sou seu bot. Como posso ajudar?";
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text(welcomeText), cancellationToken);
                }
            }
        }
    }
}
