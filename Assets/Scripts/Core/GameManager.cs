using UnityEngine;

namespace VortexLifeSim.Core
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        public PlayerStats playerStats;
        public TimeCycle timeCycle;
        public GameObject playerObject;
        public PlayerNeedsController playerNeedsController;
        public Simulation.JobSystem jobSystem;
        public Simulation.EconomyManager economyManager;

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

            if (playerNeedsController == null)
            {
                playerNeedsController = FindObjectOfType<PlayerNeedsController>();
            }

            if (jobSystem == null)
            {
                jobSystem = FindObjectOfType<Simulation.JobSystem>();
            }

            if (economyManager == null)
            {
                economyManager = FindObjectOfType<Simulation.EconomyManager>();
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
}
