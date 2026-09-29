using UnityEngine;

namespace VortexLifeSim.Housing
{
    public class PropertyOwnership : MonoBehaviour
    {
        public string ownerId = "none";
        public bool isOwned = false;
        public int price = 500;
        public int rentCost = 40;

        public void Buy(string buyerId)
        {
            ownerId = buyerId;
            isOwned = true;
            Debug.Log("Property purchased by: " + buyerId);
        }

        public void Sell(string newOwnerId)
        {
            ownerId = newOwnerId;
            isOwned = true;
            Debug.Log("Property sold to: " + newOwnerId);
        }
    }
}
