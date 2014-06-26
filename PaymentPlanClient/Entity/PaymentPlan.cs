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

        public string TutarF
        {
            get
            {
                return Tutar.HasValue ? Tutar.Value.ToString("C") : "0";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public decimal? Odenmis { get; set; }

        public string OdenmisF
        {
            get
            {
                return Odenmis.HasValue ? Odenmis.Value.ToString("C") : "0";
            }
        }

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