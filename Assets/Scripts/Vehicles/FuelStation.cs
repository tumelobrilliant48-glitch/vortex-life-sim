using UnityEngine;

namespace VortexLifeSim.Vehicles
{
    public class FuelStation : MonoBehaviour
    {
        public float refuelAmount = 50f;

        private void OnTriggerStay(Collider other)
        {
            if (!other.CompareTag("Player"))
            {
                return;
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                VehicleController vehicle = other.GetComponentInChildren<VehicleController>();
                if (vehicle != null)
                {
                    vehicle.Refuel(refuelAmount);
                    Debug.Log("Vehicle refueled.");
                }
            }
        }
    }
}
