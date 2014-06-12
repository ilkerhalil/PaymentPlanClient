namespace PaymentPlanClient.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class PaymentPlanPayTypeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public int LoanId { get; set; }

        public override string ToString()
        {
            return string.Format("LoanId: {0}", this.LoanId);
        }
    }
}