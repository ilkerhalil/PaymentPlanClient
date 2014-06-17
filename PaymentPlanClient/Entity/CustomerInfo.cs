namespace PaymentPlanClient.Entity
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class CustomerInfo
    {

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int ContactId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string TcKimlikNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string VergiKimlikNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string EntityName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string FatherName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string MotherName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<Phone> Phones { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<Adress> Adress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<Loan> Loans { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<PaymentPlan> PaymentPlans { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<Email> Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<PaymentPlanDetail> PaymentPlanDetailCollection { get; set; }



        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Agent Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public CampaignDetail CampaignDetail { get; set; }
    }
}
