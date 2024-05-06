using UnityEngine;

namespace Learn
{
    public abstract class AttackHandler : MonoBehaviour
    {
        [SerializeField] protected FloatReference damage;
        [SerializeField] protected FloatEventChannel attackEventChannel;

        private void OnTriggerEnter2D(Collider2D collision) {}
    }
}