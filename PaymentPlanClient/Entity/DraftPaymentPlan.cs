namespace PaymentPlanClient.Entity
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    [DataContract]
    public class DraftPaymentPlan
    {
        public DraftPaymentPlan()
        {

        }

        public DraftPaymentPlan(int contactId, int loanId, decimal tutar, IEnumerable<DraftPaymentPlanDetail> draftPaymentPlanDetails, short taksitSayisi, decimal? bsmv, decimal? faizTutari, short? bankCode, decimal planAnaPara)
        {
            this.ContactId = contactId;
            this.LoanId = loanId;
            this.Tutar = tutar;
            this.DraftPaymentPlanDetails = draftPaymentPlanDetails.ToList();
            this.TaksitSayisi = taksitSayisi;
            this.Bsmv = bsmv;
            this.FaizTutari = faizTutari;
            this.BankCode = bankCode;
            this.PlanAnaPara = planAnaPara;
        }

        /// <summary>
        /// koktak id
        /// </summary>
        [DataMember]
        public int ContactId { get; set; }

        /// <summary>
        /// bor� id
        /// </summary>
        [DataMember]
        public int LoanId { get; set; }

        /// <summary>
        /// tutar
        /// </summary>
        [DataMember]
        public decimal Tutar { get; set; }


        [DataMember]
        public List<DraftPaymentPlanDetail> DraftPaymentPlanDetails { get; set; }
        /// <summary>
        /// taksit say�s�
        /// </summary>
        [DataMember]
        public short TaksitSayisi { get; set; }
        /// <summary>
        ///bsm tutaru
        /// </summary>
        [DataMember]
        public decimal? Bsmv { get; set; }
        /// <summary>
        /// faiz tutar�
        /// </summary>

        [DataMember]
        public decimal? FaizTutari { get; set; }
        /// <summary>
        /// banka kodu
        /// </summary>

        [DataMember]
        public short? BankCode { get; set; }

        /// <summary>
        /// plan�n ana paras�
        /// </summary>
        [DataMember]
        public decimal PlanAnaPara { get; set; }


        public override string ToString()
        {
            return string.Format("ContactId: {0}, LoaId: {1}, DraftPaymentPlanDetails: {2}, TaksitSayisi: {3}",
                this.ContactId, this.LoanId, this.DraftPaymentPlanDetails, this.TaksitSayisi);
        }
    }
}