using System.Collections.Generic;
using UnityEngine;

namespace Learn
{
    public abstract class EventChannel<T> : ScriptableObject
    {
        readonly HashSet<EventListener<T>> listeners = new();

        public void Invoke(T value)
        {
            foreach(EventListener<T> listener in listeners)
            {
                Debug.Log($"{this.GetHashCode()} | Sent message to {listener.GetHashCode()} with value {value}.");
                listener.Raise(value);
            }
        }

        public void Register(EventListener<T> listener) => listeners.Add(listener);

        public void Deregister(EventListener<T> listener) => listeners.Remove(listener);
    }

    public readonly struct Empty { }

    [CreateAssetMenu(menuName = "Events/EventChannel")]
    public class EventChannel : EventChannel<Empty> { }
}