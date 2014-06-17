namespace PaymentPlanClient.Entity
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Contaga ait telefon bilgisini tasir.
    /// </summary>
    [DataContract]
    public class Phone
    {

        /// <summary>
        /// Phone Id bilgisini icerir
        /// </summary>
        [DataMember]
        public int PhoneId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string IletisimTipi { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Telefon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public bool Guncel { get; set; }

        public override string ToString()
        {
            return string.Format("PhoneId: {0}, IletisimTipi: {1}, Telefon: {2}, Guncel: {3}", this.PhoneId, this.IletisimTipi, this.Telefon, this.Guncel);
        }
    }
}