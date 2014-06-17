namespace PaymentPlanClient.ViewModels.Authentication
{

    /// <summary>
    /// 
    /// </summary>
    public class LogOutResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public LogOutResponse()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        public LogOutResponse(bool success, string message)
        {
            this.Success = success;
            this.Message = message;
        }

        public override string ToString()
        {
            return string.Format("Success: {0}, Message: {1}", this.Success, this.Message);
        }
    }
}