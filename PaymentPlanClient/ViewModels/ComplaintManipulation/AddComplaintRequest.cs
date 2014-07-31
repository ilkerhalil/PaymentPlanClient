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
        /// varsa kontak id'si,giriş yapmadan girilmişse boş geçilebilir
        /// 
        /// </summary>
        [DataMember]
        public int? ContactId { get; set; }

        /// <summary>
        /// formdan gelen e-posta bilgisi
        /// </summary>
        [DataMember]
        public string Email { get; set; }


        /// <summary>
        /// Sikayet edenin adi soyadi
        /// </summary>
        [DataMember]
        public string EntityName { get; set; }

        /// <summary>
        /// formdan gelen telefon numarası
        /// </summary>
        ///
        [DataMember]
        public string PhoneNo { get; set; }

        /// <summary>
        /// Sikayet tipi yoksa bos gecilebilir.
        /// </summary>
        [DataMember]
        public int? ComplaintTopicId { get; set; }

        /// <summary>
        /// formdan gelen sikayet icerigi
        /// </summary>
        [DataMember]
        public string Explanation { get; set; }

        public override string ToString()
        {
            return string.Format("ContactId: {0}, Email: {1}, EntityName: {2}, PhoneNo: {3}, ComplaintTopicId: {4}, Explanation: {5}", this.ContactId, this.Email, this.EntityName, this.PhoneNo, this.ComplaintTopicId, this.Explanation);
        }
    }
}