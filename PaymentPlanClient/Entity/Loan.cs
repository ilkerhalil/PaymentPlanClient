namespace PaymentPlanClient.Entity
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Loan
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int LoanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime Tarih { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string ParaBirimi { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Kurum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string ProtokolDurumu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public decimal? GuncelBorc { get; set; }
    }
}
