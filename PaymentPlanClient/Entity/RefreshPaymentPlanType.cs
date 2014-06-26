namespace PaymentPlanClient.Entity
{
    using System.Runtime.Serialization;

    [DataContract]
    public enum RefreshPaymentPlanType : byte
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        SonTakiteEkle = 1,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        YeniTaksitEkle = 2
    }
}