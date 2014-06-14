namespace PaymentPlanClient.Entity
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class RefreshPaymentPlan
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="refreshPaymentPlanId"></param>
        /// <param name="oldInstallmentDate"></param>
        /// <param name="newInstallmentDate"></param>
        /// <param name="oldPaymentAmount"></param>
        /// <param name="newPaymentAmount"></param>
        public RefreshPaymentPlan(int refreshPaymentPlanId, DateTime oldInstallmentDate, DateTime newInstallmentDate, decimal oldPaymentAmount, decimal newPaymentAmount)
        {
            this.RefreshPaymentPlanId = refreshPaymentPlanId;
            this.OldInstallmentDate = oldInstallmentDate;
            this.NewInstallmentDate = newInstallmentDate;
            this.OldPaymentAmount = oldPaymentAmount;
            this.NewPaymentAmount = newPaymentAmount;
        }

        /// <summary>
        /// 
        /// </summary>
        public RefreshPaymentPlan()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int RefreshPaymentPlanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime OldInstallmentDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime NewInstallmentDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Decimal OldPaymentAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Decimal NewPaymentAmount { get; set; }
    }
}