namespace PaymentPlanClient.ViewModels.AppointmentManipulation
{
    using System;
    using System.Runtime.Serialization;

    using PaymentPlanClient.Entity;

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class AppointmentRequest
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
        public AppointmentType AppointmentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime AppointmentDate { get; set; }



        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Explanation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int AgentId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int PhoneId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int EmailId { get; set; }



        public override string ToString()
        {
            return string.Format("ContactId: {0}, AppointmentType: {1}, AppointmentDate: {2}, Explanation: {3}, Agent: {4}, Phone: {5}, Email: {6}", this.ContactId, this.AppointmentType, this.AppointmentDate, this.Explanation, this.AgentId, this.PhoneId, this.EmailId);
        }
    }
}