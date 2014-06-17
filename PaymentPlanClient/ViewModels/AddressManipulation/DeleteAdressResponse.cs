namespace PaymentPlanClient.ViewModels.AddressManipulation
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using PaymentPlanClient.Entity;

    /// <summary>
    /// Adres sildikten sonra bu tipten değer döner. dönen bu tipi içinde AdressColection içinde adres listesi tutulur.
    /// </summary>
    [DataContract]
    public class DeleteAdressResponse
    {
        /// <summary>
        /// adres listesi
        /// </summary>
        [DataMember]
        public List<Adress> Adress { get; set; }

    }
}