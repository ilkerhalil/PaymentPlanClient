﻿namespace PaymentPlanClient.ViewModels
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using PaymentPlanClient.Entity;

    [DataContract]
    public class DraftPaymentPlanDetailResponse
    {
        /// <summary>
        /// Ödeme planı taslağının detaylarını tutan collection'dır
        /// </summary>
        [DataMember]
        public DraftPaymentPlan PaymentPlan { get; set; }


    }
}
