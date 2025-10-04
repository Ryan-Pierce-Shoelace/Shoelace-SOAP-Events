using UnityEngine;
namespace ShoelaceStudios.SOAP.Events
{
    [CreateAssetMenu(fileName = "New String Event", menuName = "SO Architecture/SO Event/String Event")]
    public class String_SOEvent : BaseSOEvent<string>
    {
        public void Raise() => Raise(string.Empty);
    }
}
