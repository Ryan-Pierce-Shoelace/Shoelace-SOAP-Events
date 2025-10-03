using UnityEngine;
using UnityEngine.Events;
namespace Shoelace.Events
{
    public abstract class BaseSOEventListener<TValue, TGameEvent, TUnityResponse> : MonoBehaviour,
        ISOEventListener<TValue> 
        where TGameEvent : BaseSOEvent<TValue>
        where TUnityResponse : UnityEvent<TValue> 
    {
        [SerializeField] private bool oneShotListener = false;

        [SerializeField] private TGameEvent gameEvent;
        public TGameEvent GameEvent { get { return gameEvent; } set { gameEvent = value; } }

        [SerializeField] private TUnityResponse unityEventResponse;

        private void OnEnable()
        {
            if(gameEvent == null) { return; }

            GameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            if(gameEvent == null) { return; }

            GameEvent.UnRegisterListener(this);
        }

        public void OnEventRaised(TValue item)
        {
            if(unityEventResponse != null)
            {
                unityEventResponse.Invoke(item);
            }

            if (oneShotListener)
                this.enabled = false;
        }
    }
}