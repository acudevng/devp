namespace ACU.Portals.Apply.Pages.ACUPay
{
    public interface IPaymentGateway
    {
        Task<PaymentResultDto> ProcessPaymentAsync(PaymentRequestDto paymentRequest);
    }
}