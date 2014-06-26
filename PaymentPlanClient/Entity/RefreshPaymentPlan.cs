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
        public DateTime? OldInstallmentDate { get; set; }





        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime NewInstallmentDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public decimal? OldPaymentAmount { get; set; }

        public string OldPaymentAmountF
        {
            get
            {
                return OldPaymentAmount.HasValue ? OldPaymentAmount.Value.ToString("C") : "0";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public decimal? NewPaymentAmount { get; set; }

        public string NewPaymentAmountF
        {
            get
            {
                return NewPaymentAmount.HasValue ? NewPaymentAmount.Value.ToString("C") : "0";
            }
        }
    }
}