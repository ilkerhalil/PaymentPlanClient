namespace PaymentPlanClient.ViewModels
{
    using System.Runtime.Serialization;

    [DataContract]
    public class DraftPaymentPlanDetailRequest
    {
        /// <summary>
        /// ödeme planının Kontak ID bilgisi
        /// </summary>
        [DataMember]
        public int ContactId { get; set; }

        /// <summary>
        /// ödeme planının LoanID (borç id) bilgisi 
        /// </summary>
        [DataMember]
        public int LoanId { get; set; }

        /// <summary>
        /// ödeme planının taksit sayısı
        /// </summary>
        [DataMember]
        public byte TaksitSayisi { get; set; }

        public override string ToString()
        {
            return string.Format("ContactId: {0}, LoanId: {1}, TaksitSayisi: {2}", this.ContactId, this.LoanId,
                this.TaksitSayisi);
        }
    }
}
