namespace PaymentPlanClient.ViewModels.Payment
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
        public List<RefreshPaymentPlan> RefreshPaymentPlans { get; set; }
    }
}