namespace PaymentPlanClient.Entity
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    
    public class Il
    {
        /// <summary>
        /// 
        /// </summary>
        public byte IlKodu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IlAdi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Ilce> Ilce { get; set; }

    }
}
