namespace PaymentPlanClient.ViewModels.ComplaintManipulation
{
    using System.Runtime.Serialization;

    /// <summary>
    /// şikayet kaydetmek için bu tip ile request yapılır
    /// </summary>
    [DataContract]
    public class AddComplaintRequest
    {


        /// <summary>
        /// kontak id
        /// </summary>
        [DataMember]
        public int ContactId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int ComplaintTopicId { get; set; }

        /// <summary>
        /// şikayet içeriği
        /// </summary>
        [DataMember]
        public string Explanation { get; set; }

        public override string ToString()
        {
            return string.Format("ContactId: {0}, ComplaintTopic: {1}, Explanation: {2}", this.ContactId, this.ComplaintTopicId, this.Explanation);
        }
    }
}