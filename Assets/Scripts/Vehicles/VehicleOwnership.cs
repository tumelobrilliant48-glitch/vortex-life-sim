using UnityEngine;

namespace VortexLifeSim.Vehicles
{
    public class VehicleOwnership : MonoBehaviour
    {
        public string ownerId = "player";
        public bool isStolen = false;
        public string licensePlate = "VTX-001";

        public void SetOwner(string newOwnerId)
        {
            ownerId = newOwnerId;
        }

        public void MarkStolen()
        {
            isStolen = true;
        }
    }
}
