using System.Runtime.Serialization;

namespace PaymentPlanClient.Entity
{
    [DataContract]
    public enum AppointmentType : byte
    {
        [EnumMember]
        Yuzyuze = 1,
        [EnumMember]
        Telefonla = 2
    }
}