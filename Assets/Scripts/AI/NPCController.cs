using System.Collections.Generic;
using UnityEngine;

namespace VortexLifeSim.AI
{
    public class NPCController : MonoBehaviour
    {
        public string npcName = "NPC";
        public string currentTask = "Idle";

        public enum TaskType
        {
            Idle,
            Work,
            Eat,
            Sleep,
            Relax,
            Travel,
            Socialize
        }

        public TaskType currentTaskType = TaskType.Idle;

        public List<string> dailySchedule = new List<string>
        {
            "Wake Up",
            "Eat Breakfast",
            "Go to Work",
            "Take Break",
            "Return Home",
            "Sleep"
        };

        public void SetTask(TaskType newTask)
        {
            currentTaskType = newTask;
            currentTask = newTask.ToString();
        }

        private void Update()
        {
            if (currentTaskType == TaskType.Idle)
            {
                return;
            }

            // placeholder simulation behavior
            // future AI: navigate to work/home/shop, then complete task
            Debug.Log(npcName + " is currently: " + currentTask);
        }
    }
}
