using North.Core.Payments;

namespace North.Business.Services.Payment
{
    public interface IPaymentService
    {
        InstallmentModel CheckInstallment(string binNumber, decimal price);
        PaymentResponseModel Pay(PaymentModel model);
    }
}
