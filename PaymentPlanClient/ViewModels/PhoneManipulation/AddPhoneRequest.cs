namespace PaymentPlanClient.ViewModels.PhoneManipulation
{
    using PaymentPlanClient.Entity;

    /// <summary>
    /// 
    /// </summary>
    public class AddPhoneRequest
    {

        /// <summary>
        /// 
        /// </summary>
        public PhoneType PhoneType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ContactId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Number { get; set; }

        public override string ToString()
        {
            return string.Format("PhoneType: {0}, ContactId: {1}, Number: {2}", this.PhoneType, this.ContactId, this.Number);
        }
    }
}