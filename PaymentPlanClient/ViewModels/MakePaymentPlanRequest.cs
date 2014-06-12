namespace PaymentPlanClient.ViewModels
{
    using System.Runtime.Serialization;

    using PaymentPlanClient.Entity;

    /// <summary>
    /// Plan yapmak için bu tip kullanılarak request yapılır. Plan yapmak için bu tipin kapsüllediği DraftPaymentPlan tipinde bir request gönderilir.
    /// </summary>
    [DataContract]
    public class MakePaymentPlanRequest
    {
        /// <summary>
        /// Plan taslağı tipidir.
        /// </summary>
        [DataMember]
        public DraftPaymentPlan DraftPaymentPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public short PaymentPlanPayTypeId { get; set; }

        public override string ToString()
        {
            return string.Format("DraftPaymentPlan: {0}, PaymentPlanPayTypeId: {1}", this.DraftPaymentPlan, this.PaymentPlanPayTypeId);
        }
    }
}