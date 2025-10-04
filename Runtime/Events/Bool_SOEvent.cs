using UnityEngine;
namespace ShoelaceStudios.SOAP.Events
{
    [CreateAssetMenu(fileName = "New Bool Event", menuName = "SO Architecture/SO Event/Bool Event")]
    public class Bool_SOEvent : BaseSOEvent<bool>
    {
        public void Raise() => Raise(new bool());
    }
}