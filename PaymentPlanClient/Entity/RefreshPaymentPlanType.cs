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
        AddLastPayment = 1,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        AddNewPayment = 2
    }
}