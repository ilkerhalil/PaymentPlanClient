namespace PaymentPlanClient.ViewModels.Authentication
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class AuthTicketRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string EntityName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string MotherName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Tckn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string IpAdress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string HttpUserAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public AuthTicketRequest()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entityName"></param>
        /// <param name="motherName"></param>
        /// <param name="tckn"></param>
        /// <param name="birthDate"></param>
        /// <param name="phoneNo"></param>
        /// <param name="sessionId"></param>
        /// <param name="ipAdress"></param>
        /// <param name="httpUserAgent"></param>
        public AuthTicketRequest(string entityName, string motherName, string tckn, DateTime birthDate, string phoneNo, string sessionId, string ipAdress, string httpUserAgent)
        {
            this.EntityName = entityName;
            this.MotherName = motherName;
            this.Tckn = tckn;
            this.BirthDate = birthDate;
            this.PhoneNo = phoneNo;
            this.SessionId = sessionId;
            this.IpAdress = ipAdress;
            this.HttpUserAgent = httpUserAgent;
        }

        public override string ToString()
        {
            return string.Format("EntityName: {0}, MotherName: {1}, Tckn: {2}, PhoneNo: {3}, SessionId: {4}, IpAdress: {5}, HttpUserAgent: {6}, BirthDate: {7}", this.EntityName, this.MotherName, this.Tckn, this.PhoneNo, this.SessionId, this.IpAdress, this.HttpUserAgent, this.BirthDate);
        }
    }
}