namespace PaymentPlanClient.Entity
{
    using System.Runtime.Serialization;

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Agent
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int? AgentContactId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string AgentNameAndSurName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string AgentEmail { get; set; }

        public override string ToString()
        {
            return string.Format("AgentContactId: {0}, AgentNameAndSurName: {1}, AgentEmail: {2}", this.AgentContactId, this.AgentNameAndSurName, this.AgentEmail);
        }
    }
}