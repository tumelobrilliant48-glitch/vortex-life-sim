using UnityEngine;

namespace VortexLifeSim.Interaction
{
    public class HouseMarker : InteractableObject
    {
        public int rentCost = 40;

        public override void Interact()
        {
            if (GameManager.Instance == null || GameManager.Instance.economyManager == null)
            {
                Debug.Log("Economy manager not found.");
                return;
            }

            if (GameManager.Instance.economyManager.CanAfford(rentCost))
            {
                GameManager.Instance.economyManager.SpendMoney(rentCost);
                GameManager.Instance.playerNeedsController.Rest(15f);
                Debug.Log("Player paid rent and rested at the house.");
            }
            else
            {
                Debug.Log("Not enough money to pay rent.");
            }
        }
    }
}
