namespace PaymentPlanClient.Entity
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Adres nesnesi
    /// </summary>
    [DataContract]
    public class Adress
    {
        /// <summary>
        /// adres kodu
        /// </summary>
        /// 
        [DataMember]
        public int AdresKodu { get; set; }

        /// <summary>
        /// adrestipi
        /// </summary>
        [DataMember]
        public string AdresTipi { get; set; }
        /// <summary>
        /// il(şehir)
        /// </summary>
        [DataMember]
        public string Il { get; set; }
        /// <summary>
        /// ilçe
        /// </summary>
        [DataMember]
        public string Ilce { get; set; }
        /// <summary>
        /// adres
        /// </summary>
        [DataMember]
        public string Adres { get; set; }
        /// <summary>
        /// kullanılmıyor.
        /// </summary>
        [DataMember]
        public bool Guncel { get; set; }

        public override string ToString()
        {
            return string.Format("AdresKodu: {0}, AdresTipi: {1}, Il: {2}, Ilce: {3}, Adres: {4}, Guncel: {5}", this.AdresKodu, this.AdresTipi, this.Il, this.Ilce, this.Adres, this.Guncel);
        }
    }

    public enum AdressType:byte
    {

    }
}