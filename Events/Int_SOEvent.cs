using UnityEngine;
namespace Shoelace.Events
{
    [CreateAssetMenu (fileName = "New Int Event", menuName = "SO Architecture/SO Event/Int Event")]
    public class Int_SOEvent : BaseSOEvent<int>
    {
        public void Raise() => Raise(new int());
    }
}