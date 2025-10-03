using System.Collections.Generic;
using UnityEngine;
namespace Shoelace.Events
{
    public abstract class BaseSOEvent<T> : ScriptableObject
    {
        protected readonly List<ISOEventListener<T>> eventListeners = new List<ISOEventListener<T>>();

        public virtual void Raise(T item)
        {
            for (int i = eventListeners.Count - 1; i >= 0; i--)
            {
                eventListeners[i].OnEventRaised(item);
            }
        }

        public void RegisterListener(ISOEventListener<T> listener)
        {
            //Make sure it doesnt contain the listener
            if (eventListeners.Contains(listener)) { return; }

            eventListeners.Add(listener);
        }

        public void UnRegisterListener(ISOEventListener<T> listener)
        {
            //Make sure contains the listener
            if (!eventListeners.Contains(listener)) { return; }

            eventListeners.Remove(listener);
        }
    }
}