using UnityEngine;
namespace ShoelaceStudios.SOAP.Events
{
    [CreateAssetMenu (fileName = "New Void Event", menuName = "🧩 SO Architecture/Events/Void Event")]
    public class Void_SOEvent : BaseSOEvent<Void>
    {
        public void Raise() => Raise(new Void());
    }
}