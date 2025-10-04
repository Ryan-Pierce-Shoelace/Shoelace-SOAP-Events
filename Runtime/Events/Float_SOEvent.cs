using UnityEngine;
namespace ShoelaceStudios.SOAP.Events
{
    [CreateAssetMenu (fileName = "New Float Event", menuName = "SO Architecture/SO Event/Float Event")]
    public class Float_SOEvent : BaseSOEvent<float>
    {
        public void Raise() => Raise(new float());
    }
}