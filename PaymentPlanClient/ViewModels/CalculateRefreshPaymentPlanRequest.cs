namespace PaymentPlanClient.ViewModels
{
    using System;
    using System.Runtime.Serialization;

    using PaymentPlanClient.Entity;

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class CalculateRefreshPaymentPlanRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public RefreshPaymentPlanType RefreshPaymentPlanType { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime PaymentPlanDate { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int PaymentPlanId { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public CalculateRefreshPaymentPlanRequest(int paymentPlanId, DateTime paymentPlanDate, RefreshPaymentPlanType refreshPaymentPlanType)
        {
            this.PaymentPlanId = paymentPlanId;
            this.PaymentPlanDate = paymentPlanDate;
            this.RefreshPaymentPlanType = refreshPaymentPlanType;

        }

        /// <summary>
        /// 
        /// </summary>
        public CalculateRefreshPaymentPlanRequest()
        {

        }

    }
}