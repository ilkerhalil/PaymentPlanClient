namespace PaymentPlanClient.ViewModels.EmailManipulation
{
    using PaymentPlanClient.Entity;

    /// <summary>
    /// 
    /// </summary>
    public class AddEmailRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public EmailType EmailType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ContactId { get; set; }

        public override string ToString()
        {
            return string.Format("Email: {0}, ContactId: {1}", this.Email, this.ContactId);
        }
    }
}