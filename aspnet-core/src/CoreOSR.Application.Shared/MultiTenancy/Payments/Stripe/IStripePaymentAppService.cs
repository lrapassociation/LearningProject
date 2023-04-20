using System.Threading.Tasks;
using Abp.Application.Services;
using CoreOSR.MultiTenancy.Payments.Dto;
using CoreOSR.MultiTenancy.Payments.Stripe.Dto;

namespace CoreOSR.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}