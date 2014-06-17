using System.Runtime.Serialization;

namespace PaymentPlanClient.Entity
{
    [DataContract]
    public enum AppointmentType : byte
    {
        [EnumMember]
        FaceOfFace = 1,
        [EnumMember]
        OnPhone = 2
    }
}