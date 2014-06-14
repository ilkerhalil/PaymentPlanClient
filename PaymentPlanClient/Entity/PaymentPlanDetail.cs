namespace PaymentPlanClient.Entity
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class PaymentPlanDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int PaymentPlanDetailId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public decimal TaksitTutari { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime TaksitTarihi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public decimal Odeme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Durum { get; set; }

        public override string ToString()
        {
            return string.Format("PaymentPlanDetailId: {0}, TaksitTutari: {1}, TaksitTarihi: {2}, Odeme: {3}, Durum: {4}", this.PaymentPlanDetailId, this.TaksitTutari, this.TaksitTarihi, this.Odeme, this.Durum);
        }
    }
}