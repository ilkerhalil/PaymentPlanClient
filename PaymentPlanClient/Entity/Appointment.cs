namespace PaymentPlanClient.Entity
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public class Appointment
    {
        public override string ToString()
        {
            return string.Format("AppointmentId: {0}, AppointmentDate: {1}", this.AppointmentId, this.AppointmentDate);
        }

        /// <summary>
        /// 
        /// </summary>
        public int AppointmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime AppointmentDate { get; set; }



    }
}
