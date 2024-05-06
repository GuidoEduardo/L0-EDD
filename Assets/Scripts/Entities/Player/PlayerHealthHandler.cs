using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn
{
    public class PlayerHealthHandler : MonoBehaviour
    {
        public FloatReference currentHealth;
        public FloatReference maxHealth;
        public bool resetHealth = true;

        [SerializeField] EventChannel onDamageEventChannel;

        private void Awake()
        {
            if (resetHealth)
            {
                currentHealth.variable.value = maxHealth.value;
            }
        }

        public void TakeDamage(float damage)
        {
            currentHealth.variable.value -= damage;
            onDamageEventChannel?.Invoke(new Empty());
        }
    }
}
