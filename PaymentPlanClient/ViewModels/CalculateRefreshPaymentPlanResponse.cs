namespace PaymentPlanClient.ViewModels
{
    using System.Collections.Generic;

    using PaymentPlanClient.Entity;

    /// <summary>
    /// 
    /// </summary>
    public class CalculateRefreshPaymentPlanResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<RefreshPaymentPlan> RefreshPaymentPlans { get; set; }
    }
}