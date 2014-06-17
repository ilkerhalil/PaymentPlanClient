namespace PaymentPlanClient.ViewModels
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using PaymentPlanClient.Entity;

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class CalculateRefreshPaymentPlanResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public IEnumerable<RefreshPaymentPlan> RefreshPaymentPlans { get; set; }
    }
}