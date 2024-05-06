using System.Collections.Generic;
using UnityEngine;

namespace Learn
{
    public abstract class EventChannel<T> : ScriptableObject
    {
        readonly HashSet<EventListener<T>> listeners = new();

        public void Invoke(T value)
        {
            Debug.Log($"{this.GetHashCode()} sending message with value {value}.");
            foreach (EventListener<T> listener in listeners)
            {
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