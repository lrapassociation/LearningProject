using System.Threading.Tasks;
using CoreOSR.Authorization.Users;

namespace CoreOSR.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
