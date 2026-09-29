using UnityEngine;

namespace VortexLifeSim.Vehicles
{
    public class VehicleDamageSystem : MonoBehaviour
    {
        public float maxHealth = 100f;
        public float currentHealth = 100f;
        public float collisionDamageThreshold = 8f;

        private Rigidbody rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            float impact = collision.relativeVelocity.magnitude;
            if (impact > collisionDamageThreshold)
            {
                float damage = impact * 1.2f;
                currentHealth = Mathf.Clamp(currentHealth - damage, 0f, maxHealth);
                Debug.Log("Vehicle hit! Current health: " + currentHealth);
            }
        }

        public void Repair(float amount)
        {
            currentHealth = Mathf.Clamp(currentHealth + amount, 0f, maxHealth);
        }
    }
}
