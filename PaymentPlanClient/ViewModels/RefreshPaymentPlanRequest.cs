namespace PaymentPlanClient.ViewModels
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class RefreshPaymentPlanRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public byte RefreshPaymentPlanTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime PaymentPlanDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int PaymentPlanId { get; set; }
    }
}