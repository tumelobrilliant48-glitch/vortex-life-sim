using UnityEngine;

namespace VortexLifeSim.Education
{
    public class SchoolMarker : MonoBehaviour
    {
        public string schoolName = "Village School";

        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player"))
            {
                return;
            }

            Debug.Log("Player entered " + schoolName + ".");
        }
    }
}
