using UnityEngine;

namespace Learn
{
    public class EnemyAttackHandler: AttackHandler 
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                attackEventChannel?.Invoke(damage.value);
            }
        }
    }
}