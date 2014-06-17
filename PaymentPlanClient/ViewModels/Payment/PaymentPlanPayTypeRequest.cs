namespace PaymentPlanClient.ViewModels.Payment
{
    using System.Runtime.Serialization;

    /// <summary>
    /// 
    /// </summary>
    public class PaymentPlanPayTypeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int LoanId { get; set; }

        public override string ToString()
        {
            return string.Format("LoanId: {0}", this.LoanId);
        }
    }
}