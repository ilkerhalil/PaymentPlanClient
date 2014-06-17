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