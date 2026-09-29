using UnityEngine;

namespace VortexLifeSim.World
{
    public class TimeCycle : MonoBehaviour
    {
        public float minutesPerSecond = 6f;
        public float currentMinute = 0f;
        public int currentHour = 6;
        public int currentDay = 1;

        private float inGameMinuteTimer;

        public void Tick(float deltaTime)
        {
            inGameMinuteTimer += deltaTime * minutesPerSecond;

            while (inGameMinuteTimer >= 1f)
            {
                inGameMinuteTimer -= 1f;
                currentMinute += 1f;

                if (currentMinute >= 60f)
                {
                    currentMinute = 0f;
                    currentHour += 1;

                    if (currentHour >= 24)
                    {
                        currentHour = 0;
                        currentDay += 1;
                    }
                }
            }
        }
    }
}
