using System.Collections.Generic;
using UnityEngine;

namespace VortexLifeSim.AI
{
    public class NPCScheduleController : MonoBehaviour
    {
        public string npcName = "Villager";
        public string currentTask = "Idle";
        public List<string> schedule = new List<string>
        {
            "Wake Up",
            "Eat Breakfast",
            "Go to Work",
            "Take Lunch",
            "Return Home",
            "Rest",
            "Sleep"
        };

        private int currentIndex;
        private float tickTimer;
        public float scheduleTickTime = 5f;

        private void Update()
        {
            tickTimer += Time.deltaTime;

            if (tickTimer < scheduleTickTime)
            {
                return;
            }

            tickTimer = 0f;
            currentIndex = (currentIndex + 1) % schedule.Count;
            currentTask = schedule[currentIndex];
            Debug.Log(npcName + " is now: " + currentTask);
        }
    }
}
