namespace PaymentPlanClient.ViewModels.ComplaintManipulation
{
    using LBTCustomerCentricWebsite.WebApi2.Model;

    /// <summary>
    /// 
    /// </summary>
    public class AddComplaintResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public Complaint Complaint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }

        public override string ToString()
        {
            return string.Format("Complaint: {0}, Message: {1}", this.Complaint, this.Message);
        }
    }
}