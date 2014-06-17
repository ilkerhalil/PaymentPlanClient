namespace LBTCustomerCentricWebsite.WebApi2.ViewModel
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteAdressRequest
    {

        /// <summary>
        /// 
        /// </summary>
        public int ContactId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public int AdressId { get; set; }

        public override string ToString()
        {
            return string.Format("ContactId: {0}, AdressId: {1}", this.ContactId, this.AdressId);
        }
    }
}