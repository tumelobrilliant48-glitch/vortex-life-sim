using System;
using UnityEngine;
using VortexLifeSim.World;

namespace VortexLifeSim.Core
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        public PlayerStats playerStats;
        public TimeCycle timeCycle;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);

            InitializeGame();
        }

        private void InitializeGame()
        {
            if (playerStats == null)
            {
                playerStats = new PlayerStats();
            }

            if (timeCycle == null)
            {
                timeCycle = FindObjectOfType<TimeCycle>();
            }

            if (timeCycle == null)
            {
                GameObject timeObject = new GameObject("TimeCycle");
                timeObject.transform.SetParent(transform);
                timeCycle = timeObject.AddComponent<TimeCycle>();
            }
        }

        private void Update()
        {
            if (timeCycle != null)
            {
                timeCycle.Tick(Time.deltaTime);
            }
        }
    }

    [Serializable]
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
