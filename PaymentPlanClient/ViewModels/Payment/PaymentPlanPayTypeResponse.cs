﻿namespace PaymentPlanClient.ViewModels.Payment
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using PaymentPlanClient.Entity;

    /// <summary>
    /// 
    /// </summary>
    /// 
    [DataContract]
    public class PaymentPlanPayTypeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<PaymentPlanPayType> PaymentPlanPayTypes { get; set; }


    }
}
