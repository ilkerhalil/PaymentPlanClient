namespace PaymentPlanClient.Entity
{
    using System.Runtime.Serialization;

    [DataContract]
    public class PaymentPlanPayType
    {
        public PaymentPlanPayType()
        {
            
        }

        public PaymentPlanPayType(short bankCode, string bankaOdemeNotu)
        {
            this.BankCode = bankCode;
            this.BankaOdemeNotu = bankaOdemeNotu;
        }

        

        [DataMember]
        public short BankCode { get; set; }

        [DataMember]
        public string BankaOdemeNotu { get; set; }
    }
}