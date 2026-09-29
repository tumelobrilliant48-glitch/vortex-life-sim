using UnityEngine;

namespace VortexLifeSim.Family
{
    public class ChildGrowthSystem : MonoBehaviour
    {
        public int age = 0;
        public bool isAdult = false;

        public void GrowYear()
        {
            age++;
            if (age >= 18)
            {
                isAdult = true;
            }
        }
    }
}
