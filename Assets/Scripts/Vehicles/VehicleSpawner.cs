using UnityEngine;

namespace VortexLifeSim.Vehicles
{
    public class VehicleSpawner : MonoBehaviour
    {
        public GameObject vehiclePrefab;
        public Vector3 spawnPosition = new Vector3(10f, 1f, 5f);

        private void Start()
        {
            if (vehiclePrefab != null)
            {
                Instantiate(vehiclePrefab, spawnPosition, Quaternion.identity);
            }
        }
    }
}
