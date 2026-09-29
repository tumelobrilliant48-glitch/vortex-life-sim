using UnityEngine;
using VortexLifeSim.Core;

namespace VortexLifeSim.Core
{
    public class PlayerNeedsController : MonoBehaviour
    {
        public float hungerDecayPerMinute = 1.2f;
        public float thirstDecayPerMinute = 1.4f;
        public float hygieneDecayPerMinute = 0.8f;
        public float healthDecayPerMinute = 0.3f;

        private PlayerStats stats;

        private void Start()
        {
            if (GameManager.Instance != null)
            {
                stats = GameManager.Instance.playerStats;
            }
        }

        private void Update()
        {
            if (GameManager.Instance != null && GameManager.Instance.playerStats != null)
            {
                stats = GameManager.Instance.playerStats;
            }

            if (stats == null)
            {
                return;
            }

            float delta = Time.deltaTime / 60f;
            stats.ApplyDecay(
                hungerDecayPerMinute * delta,
                thirstDecayPerMinute * delta,
                hygieneDecayPerMinute * delta
            );

            if (stats.hunger <= 10f || stats.thirst <= 10f)
            {
                stats.health = Mathf.Clamp(stats.health - healthDecayPerMinute * delta, 0f, 100f);
            }
        }

        public void EatFood(float value)
        {
            if (stats == null)
            {
                return;
            }

            stats.hunger = Mathf.Clamp(stats.hunger + value, 0f, 100f);
        }

        public void DrinkWater(float value)
        {
            if (stats == null)
            {
                return;
            }

            stats.thirst = Mathf.Clamp(stats.thirst + value, 0f, 100f);
        }

        public void TakeShower(float value)
        {
            if (stats == null)
            {
                return;
            }

            stats.hygiene = Mathf.Clamp(stats.hygiene + value, 0f, 100f);
        }

        public void RecoverHealth(float value)
        {
            if (stats == null)
            {
                return;
            }

            stats.health = Mathf.Clamp(stats.health + value, 0f, 100f);
        }
    }
}
