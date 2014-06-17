namespace PaymentPlanClient.ViewModels.AddressManipulation
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Adres eklemek için bu tip ile request yapılır
    /// </summary>
    
    [DataContract]
    public class AddAdressRequest
    {


        /// <summary>
        /// Adres tip
        /// </summary>
        [DataMember]
        public AddressType AddresType { get; set; }


        /// <summary>
        /// Kontak ID
        /// </summary>
        [DataMember]
        public int ContactId { get; set; }


        /// <summary>
        /// il kodu
        /// </summary>
        [DataMember]
        public short? IlKodu { get; set; }

        /// <summary>
        /// ilçe kodu
        /// </summary>
        [DataMember]
        public short? IlceKodu { get; set; }

        /// <summary>
        /// cadde
        /// </summary>
        [DataMember]
        public string Cadde { get; set; }

        /// <summary>
        /// mahalle
        /// </summary>
        [DataMember]
        public string Mahalle { get; set; }

        /// <summary>
        /// sokak
        /// </summary>
        [DataMember]
        public string Sokak { get; set; }

        /// <summary>
        /// numara
        /// </summary>
        [DataMember]
        public string Numara { get; set; }

        /// <summary>
        /// daire
        /// </summary>
        [DataMember]
        public int? Daire { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public AddAdressRequest()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ilKodu">il kodu</param>
        /// <param name="ilceKodu">ilçe kodu</param>
        /// <param name="cadde">cadde</param>
        /// <param name="mahalle">mahalle</param>
        /// <param name="sokak">sokak</param>
        /// <param name="numara">numara</param>
        /// <param name="daire">daire</param>
        public AddAdressRequest(byte ilKodu, short ilceKodu, string cadde, string mahalle, string sokak, string numara, int daire)
        {
            this.IlKodu = ilKodu;
            this.IlceKodu = ilceKodu;
            this.Cadde = cadde;
            this.Mahalle = mahalle;
            this.Sokak = sokak;
            this.Numara = numara;
            this.Daire = daire;
        }

        public override string ToString()
        {
            return string.Format("AddresType: {0}, ContactId: {1}, IlKodu: {2}, IlceKodu: {3}, Cadde: {4}, Mahalle: {5}, Sokak: {6}, Numara: {7}, Daire: {8}", this.AddresType, this.ContactId, this.IlKodu, this.IlceKodu, this.Cadde, this.Mahalle, this.Sokak, this.Numara, this.Daire);
        }
    }
}