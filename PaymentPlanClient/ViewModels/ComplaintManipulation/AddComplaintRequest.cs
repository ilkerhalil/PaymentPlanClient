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
        public string Email { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string EntityName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        ///
        [DataMember]
        public string PhoneNo { get; set; }

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
            return string.Format("ContactId: {0}, Email: {1}, EntityName: {2}, PhoneNo: {3}, ComplaintTopicId: {4}, Explanation: {5}", this.ContactId, this.Email, this.EntityName, this.PhoneNo, this.ComplaintTopicId, this.Explanation);
        }
    }
}