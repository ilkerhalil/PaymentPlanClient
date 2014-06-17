using System.Runtime.Serialization;

namespace LBTCustomerCentricWebsite.WebApi2.Model
{
    /// <summary>
    /// Şikayetin konusu
    /// </summary>
   [DataContract]
    public class ComplaintTopic
    {
        /// <summary>
        /// konu id
        /// </summary>
      [DataMember]
       public int ComplaintTopicId { get; set; }

        /// <summary>
        /// konu adı
        /// </summary>
       [DataMember] 
       public string ComplaintTopicName { get; set; }

        public override string ToString()
        {
            return string.Format("ComplaintTopicId: {0}, ComplaintTopic: {1}", this.ComplaintTopicId, this.ComplaintTopicName);
        }
    }
}