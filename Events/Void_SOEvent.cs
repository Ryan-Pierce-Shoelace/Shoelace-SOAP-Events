using UnityEngine;
namespace Shoelace.Events
{
    [CreateAssetMenu (fileName = "New Void Event", menuName = "SO Architecture/SO Event/Void Event")]
    public class Void_SOEvent : BaseSOEvent<Void>
    {
        public void Raise() => Raise(new Void());
    }
}