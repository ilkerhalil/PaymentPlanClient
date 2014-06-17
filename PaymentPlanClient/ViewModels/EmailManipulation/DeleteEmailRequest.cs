namespace LBTCustomerCentricWebsite.WebApi2.ViewModel
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteEmailRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public int EmailId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ContactId { get; set; }

        public override string ToString()
        {
            return string.Format("EmailId: {0}, ContactId: {1}", this.EmailId, this.ContactId);
        }
    }
}