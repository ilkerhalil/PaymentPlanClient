namespace PaymentPlanClient.ViewModels.AddressManipulation
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using PaymentPlanClient.Entity;

    /// <summary>
    /// Adres Responce
    /// </summary>
    [DataContract]
    public class AddAdressResponse
    {
        /// <summary>
        /// Adres collection
        /// </summary>
        [DataMember]
        public List<Adress> Adress { get; set; }

    }
}