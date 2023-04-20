using System.Threading.Tasks;
using Abp.Webhooks;

namespace CoreOSR.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
