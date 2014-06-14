namespace PaymentPlanClient.ViewModels
{
    using System.Runtime.Serialization;

    using PaymentPlanClient.Entity;

    [DataContract]
    public class DraftPaymentPlanDetailResponse
    {
        /// <summary>
        /// Ödeme planı taslağının detaylarını tutan collection'dır
        /// </summary>
        [DataMember]
        public DraftPaymentPlan DraftPaymentPlan { get; set; }


    }
}
