namespace PaymentPlanClient.ViewModels.AppointmentManipulation
{
    using PaymentPlanClient.Entity;

    /// <summary>
    /// 
    /// </summary>
    public class AppointmentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public Appointment Appointment { get; set; }

        public override string ToString()
        {
            return string.Format("Appointment: {0}", this.Appointment);
        }
    }
}