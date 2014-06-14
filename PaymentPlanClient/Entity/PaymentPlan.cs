namespace PaymentPlanClient.Entity
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class PaymentPlan
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int PaymentPlanId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int? BorcKodu { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public decimal? Tutar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public decimal? Odenmis { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int? Taksit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Durumu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// 
        [DataMember]
        public List<PaymentPlanDetail> PaymentPlanDetails { get; set; }


    }
}