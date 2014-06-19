namespace PaymentPlanClient.Entity
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Adres tipi Ev=1,is=2,diğer=3
    /// </summary>
    [DataContract]
    public enum AddressType : byte
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        Ev = 1,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        Is = 2,
        /// <summary>
        /// 
        /// </summary>
        [EnumMember]
        Diger = 3
    }
}