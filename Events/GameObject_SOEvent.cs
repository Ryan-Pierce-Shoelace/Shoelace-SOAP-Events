using UnityEngine;
namespace Shoelace.Events
{
    /// <summary>
    /// Note that due to protection levels you can't make a transform event, so in those cases use this instead then just get the transform afterwards
    /// </summary>
    [CreateAssetMenu (fileName = "New GameObject Event", menuName = "SO Architecture/SO Event/GameObject Event")]
    public class GameObject_SOEvent : BaseSOEvent<GameObject>
    {
        public void Raise() => Raise(new GameObject());
    }
}