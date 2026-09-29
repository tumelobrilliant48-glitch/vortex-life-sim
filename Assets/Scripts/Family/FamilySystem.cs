using UnityEngine;

namespace VortexLifeSim.Family
{
    public class FamilySystem : MonoBehaviour
    {
        public int childCount = 0;
        public string familyName = "Player Family";

        public void AddChild()
        {
            childCount++;
            Debug.Log("Child added. Total children: " + childCount);
        }

        public void RemoveChild()
        {
            if (childCount > 0)
            {
                childCount--;
            }
        }
    }
}
