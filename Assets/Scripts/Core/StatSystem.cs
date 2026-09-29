using UnityEngine;

namespace VortexLifeSim.Core
{
    public class StatSystem : MonoBehaviour
    {
        public PlayerStats stats;

        private void Start()
        {
            stats = GameManager.Instance.playerStats;
        }

        public void EatFood(float hungerGain)
        {
            stats.hunger = Mathf.Clamp(stats.hunger + hungerGain, 0f, 100f);
        }

        public void DrinkWater(float thirstGain)
        {
            stats.thirst = Mathf.Clamp(stats.thirst + thirstGain, 0f, 100f);
        }

        public void Wash(float hygieneGain)
        {
            stats.hygiene = Mathf.Clamp(stats.hygiene + hygieneGain, 0f, 100f);
        }

        public void Rest(float energyGain)
        {
            stats.energy = Mathf.Clamp(stats.energy + energyGain, 0f, 100f);
        }
    }
}
