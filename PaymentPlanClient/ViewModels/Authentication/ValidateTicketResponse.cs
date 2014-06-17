namespace PaymentPlanClient.ViewModels.Authentication
{
    using System.Runtime.Serialization;

    using PaymentPlanClient.Entity;

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ValidateTicketResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public CustomerInfo CustomerInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ValidateTicketResponse()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="customerInfo"></param>
        public ValidateTicketResponse(bool success, string message, CustomerInfo customerInfo)
        {
            this.Success = success;
            this.Message = message;
            this.CustomerInfo = customerInfo;
        }

        public override string ToString()
        {
            return string.Format("Success: {0}, Message: {1}, CustomerInfo: {2}", this.Success, this.Message, this.CustomerInfo);
        }
    }


}