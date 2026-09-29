using UnityEngine;

namespace VortexLifeSim.Vehicles
{
    public class VehicleLicenseSystem : MonoBehaviour
    {
        public bool hasDriverLicense = false;
        public bool canDrive = false;

        public void AcquireLicense()
        {
            hasDriverLicense = true;
            canDrive = true;
            Debug.Log("Driver license acquired.");
        }

        public bool TryDrive()
        {
            if (!hasDriverLicense)
            {
                Debug.Log("Player does not have a valid driver license.");
                return false;
            }

            canDrive = true;
            return true;
        }
    }
}
