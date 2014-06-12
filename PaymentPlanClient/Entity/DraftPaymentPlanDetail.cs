namespace PaymentPlanClient.Entity
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class DraftPaymentPlanDetail
    {

        public DraftPaymentPlanDetail()
        {

        }

        public DraftPaymentPlanDetail(int sira, decimal tutarA, decimal tutarT, decimal kTutarT, decimal kumulatif, decimal fmMatrah, decimal finMal, int gunF, DateTime tarih)
        {
            this.Sira = sira;
            this.TutarA = tutarA;
            this.TutarT = tutarT;
            this.KTutarT = kTutarT;
            this.Kumulatif = kumulatif;
            this.FMMatrah = fmMatrah;
            this.FinMal = finMal;
            this.GunF = gunF;
            this.Tarih = tarih;
        }

        /// <summary>
        /// sirasi
        /// </summary>
        [DataMember]
        public int Sira { get; set; }

        /// <summary>
        /// TutarA
        /// </summary>
        [DataMember]
        public decimal TutarA { get; set; }

        /// <summary>
        /// TutarT
        /// </summary>
        [DataMember]
        public decimal TutarT { get; set; }

        /// <summary>
        /// KTutarT
        /// </summary>
        [DataMember]
        public decimal KTutarT { get; set; }

        /// <summary>
        /// Kumulatif
        /// </summary>
        [DataMember]
        public decimal Kumulatif { get; set; }

        /// <summary>
        /// FMMatrah
        /// </summary>
        [DataMember]
        public decimal FMMatrah { get; set; }

        /// <summary>
        /// FinMal
        /// </summary>
        [DataMember]
        public Decimal FinMal { get; set; }

        /// <summary>
        /// GunF
        /// </summary>
        [DataMember]
        public int GunF { get; set; }

        /// <summary>
        /// tarih
        /// </summary>
        [DataMember]
        public DateTime Tarih { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return
                string.Format(
                    "Sira: {0}, TutarA: {1}, TutarT: {2}, KTutarT: {3}, Kumulatif: {4}, FMMatrah: {5}, FinMal: {6}, GunF: {7}, Tarih: {8}",
                    this.Sira, this.TutarA, this.TutarT, this.KTutarT, this.Kumulatif, this.FMMatrah, this.FinMal,
                    this.GunF, this.Tarih);
        }
    }
}