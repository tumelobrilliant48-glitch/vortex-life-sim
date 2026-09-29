using UnityEngine;

namespace VortexLifeSim.Housing
{
    public class HouseBuildingProgress : MonoBehaviour
    {
        public int daysRequired = 10;
        public int currentDays = 0;
        public bool completed = false;

        public void AdvanceBuildDay()
        {
            if (completed)
            {
                return;
            }

            currentDays++;
            if (currentDays >= daysRequired)
            {
                completed = true;
                Debug.Log("House construction complete.");
            }
        }
    }
}
