using UnityEngine;
namespace ShoelaceStudios.SOAP.Events
{
    [CreateAssetMenu (fileName = "New Int Event", menuName = "🧩 SO Architecture/Events/Int Event")]
    public class Int_SOEvent : BaseSOEvent<int>
    {
        public void Raise() => Raise(new int());
    }
}