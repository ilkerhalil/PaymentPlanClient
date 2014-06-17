namespace PaymentPlanClient.ViewModels
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ValidateTicketRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string PhoneNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int Ticket { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string MotherName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string SmsCode { get; set; }
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
        [DataMember]
        public string Tckn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ValidateTicketRequest()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="phoneNo"></param>
        /// <param name="ticket"></param>
        /// <param name="motherName"></param>
        /// <param name="smsCode"></param>
        /// <param name="sessionId"></param>
        /// <param name="ipAdress"></param>
        /// <param name="httpUserAgent"></param>
        /// <param name="birthDate"></param>
        /// <param name="tckn"></param>
        public ValidateTicketRequest(string phoneNo, int ticket, string motherName, string smsCode, string sessionId, string ipAdress, string httpUserAgent, DateTime birthDate, string tckn)
        {
            this.PhoneNo = phoneNo;
            this.Ticket = ticket;
            this.MotherName = motherName;
            this.SmsCode = smsCode;
            this.SessionId = sessionId;
            this.IpAdress = ipAdress;
            this.HttpUserAgent = httpUserAgent;
            this.BirthDate = birthDate;
            this.Tckn = tckn;
        }

        public override string ToString()
        {
            return string.Format("PhoneNo: {0}, Ticket: {1}, MotherName: {2}, SmsCode: {3}, SessionId: {4}, IpAdress: {5}, HttpUserAgent: {6}, BirthDate: {7}, Tckn: {8}", this.PhoneNo, this.Ticket, this.MotherName, this.SmsCode, this.SessionId, this.IpAdress, this.HttpUserAgent, this.BirthDate, this.Tckn);
        }
    }
}