using UnityEngine;
using UnityEngine.Events;

namespace Learn
{
    public abstract class EventListener<T> : MonoBehaviour 
    {
        [SerializeField] EventChannel<T> channel;
        [SerializeField] UnityEvent<T> response;

        private void Awake()
        {
            channel.Register(this);
        }

        private void OnDestroy()
        {
            channel.Deregister(this);
        }
        
        public void Raise(T value)
        {
            Debug.Log($"{this.GetHashCode()} received message with value {value}.");
            response?.Invoke(value);
        }
    }

    public class EventListener : EventListener<Empty> { }
}