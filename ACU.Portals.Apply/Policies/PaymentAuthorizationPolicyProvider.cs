using System;
using Microsoft.AspNetCore.Authorization;

namespace ACU.Portals.Apply.Policies
{
    public class PaymentAuthorizationPolicyProvider : IAuthorizationPolicyProvider
    {
        public Task<AuthorizationPolicy?> GetFallbackPolicyAsync()
        {
            return Task.FromResult<AuthorizationPolicy>(null);
        }

        Task<AuthorizationPolicy> IAuthorizationPolicyProvider.GetDefaultPolicyAsync()
        {
            var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().
                 RequireClaim("paymentStatus", "paid").Build();
            return Task.FromResult(policy);
        }

       

        Task<AuthorizationPolicy?> IAuthorizationPolicyProvider.GetPolicyAsync(string policyName)
        {
            if (policyName == "PaidPolicy")
            {
                var policy = new AuthorizationPolicyBuilder().
                    RequireAuthenticatedUser().
                    RequireClaim("paymentStatus", "paid").Build();
                return Task.FromResult(policy);
            }
            return Task.FromResult<AuthorizationPolicy>(null);
        }

    }
}

