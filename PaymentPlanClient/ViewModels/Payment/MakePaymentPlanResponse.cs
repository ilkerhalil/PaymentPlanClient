namespace PaymentPlanClient.ViewModels.Payment
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using PaymentPlanClient.Entity;

    /// <summary>
    /// Ödeme planlarının tutulduğu response
    /// </summary>
    [DataContract]
    public class MakePaymentPlanResponse
    {
        /// <summary>
        /// Ödeme planlarının tutulduğu collection
        /// </summary>
        [DataMember]
        public List<PaymentPlan> PaymentPlanCollection { get; set; }


    }
}