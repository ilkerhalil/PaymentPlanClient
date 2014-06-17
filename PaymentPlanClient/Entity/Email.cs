namespace PaymentPlanClient.Entity
{
    using System.Runtime.Serialization;

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Email
    {
        /// <summary>
        /// 
        /// </summary>
        /// 
    [DataMember]
        public int EmailId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string EMail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public bool Guncel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public EmailType EmailType { get; set; }

        public override string ToString()
        {
            return string.Format("EmailId: {0}, EMail: {1}, Guncel: {2}", this.EmailId, this.EMail, this.Guncel);
        }
    }
}
