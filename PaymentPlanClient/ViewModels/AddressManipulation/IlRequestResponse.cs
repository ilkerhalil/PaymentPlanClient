namespace PaymentPlanClient.ViewModels.AddressManipulation
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using PaymentPlanClient.Entity;

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class IlRequestResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<Il> IlCollection { get; set; }

    }
}