using System;
using System.Security.Claims;
using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Identity;
using Volo.Abp.DependencyInjection;

namespace ACU.Portals.Apply.Pages.ACUPay
{
	public class ACUPayGate: IPaymentGateway, ITransientDependency
    {
		IPaymentGateway _ACUPayGate;
		

        public ACUPayGate(IPaymentGateway ACUPayGate)
		{
			_ACUPayGate = _ACUPayGate;
		}
		public async Task<PaymentResultDto> ProcessPaymentAsync(PaymentRequestDto paymentRequest)
		{
			//{
			//	//Call the ProcessPaymentAsync
			//	var paymentResult = await _ACUPayGate.ProcessPaymentAsync(paymentRequest);
			//	//update the payment status claim for the current user
			//	var currentUser = //await GetCurrentUserAsync();
			//	var claims = //userManager.GetClaimsAsync(currentUser);
			//	var paymentStatusClaim = claims.FirstOrDefault(c => c.Type == "paymentStatus");
			//	if (paymentStatusClaim == null)
			//	{
			//		await UserManager.AddClaimAsync(currentUser, new Claim("paymentStatus", paymentResult.Status.ToString()));


			//	}
			//	else
			//	{
			//		await UserManager.ReplaceClaimAsync(currentUser, paymentStatusClaim, new Claim("paymentStatus", paymentResult.Status.ToString()));
			//	}
			//	//Create a new payment entity and store in db
			//	var payment = ObjectMapper.Map<PaymentRequestDto, Payment>(paymentRequest);

			//	payment.PaymentDate = DateTime.Now;
			//	payment.Status = paymentResult.Status;
			//	payment.Message = paymentResult.Message;
			//	await _paymentRepository.InsertAsync(payment);
			//	return paymentResult;
			return null;
		}
	}
}

