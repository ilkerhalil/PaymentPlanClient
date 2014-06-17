namespace PaymentPlanClient.ViewModels.Authentication
{
    using System.Runtime.Serialization;

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class AuthTicketResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int Ticket { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public AuthTicketResponse()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ticket"></param>
        /// <param name="phoneNo"></param>
        public AuthTicketResponse(int ticket, string phoneNo)
        {
            this.Ticket = ticket;
            this.PhoneNo = phoneNo;
        }

        public override string ToString()
        {
            return string.Format("Ticket: {0}, PhoneNo: {1}", this.Ticket, this.PhoneNo);
        }
    }
}
