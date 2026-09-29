using UnityEngine;

namespace VortexLifeSim.Core
{
    [System.Serializable]
    public class PlayerStats
    {
        public float hunger = 100f;
        public float thirst = 100f;
        public float health = 100f;
        public float hygiene = 100f;
        public float happiness = 100f;
        public float fitness = 50f;
        public float energy = 100f;
        public int money = 0;
        public int age = 18;

        public void ApplyDecay(float hungerLoss, float thirstLoss, float hygieneLoss)
        {
            hunger = Mathf.Clamp(hunger - hungerLoss, 0f, 100f);
            thirst = Mathf.Clamp(thirst - thirstLoss, 0f, 100f);
            hygiene = Mathf.Clamp(hygiene - hygieneLoss, 0f, 100f);
        }
    }
}
