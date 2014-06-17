namespace PaymentPlanClient.ViewModels.Payment
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using PaymentPlanClient.Entity;

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class RefreshPaymentPlanResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<PaymentPlan> PaymentPlans { get; set; }
    }
}