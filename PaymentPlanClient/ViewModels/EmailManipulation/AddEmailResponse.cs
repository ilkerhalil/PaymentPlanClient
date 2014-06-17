namespace PaymentPlanClient.ViewModels.EmailManipulation
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using PaymentPlanClient.Entity;

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class AddEmailResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<Email> Emails { get; set; }

        
    }
}