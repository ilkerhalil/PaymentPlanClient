namespace PaymentPlanClient.ViewModels.PhoneManipulation
{
    /// <summary>
    /// 
    /// </summary>
    public class DeletePhoneRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public int PhoneId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public int ContactId { get; set; }

        public override string ToString()
        {
            return string.Format("PhoneId: {0}, ContactId: {1}", this.PhoneId, this.ContactId);
        }
    }
}