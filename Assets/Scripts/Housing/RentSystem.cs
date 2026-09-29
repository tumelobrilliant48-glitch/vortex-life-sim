using UnityEngine;

namespace VortexLifeSim.Housing
{
    public class RentSystem : MonoBehaviour
    {
        public int rentAmount = 40;

        public void PayRent()
        {
            Debug.Log("Rent paid: $" + rentAmount);
        }
    }
}
