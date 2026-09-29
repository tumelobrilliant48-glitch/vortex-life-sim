using UnityEngine;

namespace VortexLifeSim.Interaction
{
    public class ShopMarker : InteractableObject
    {
        public int itemCost = 20;
        public string itemName = "Food";

        public override void Interact()
        {
            if (GameManager.Instance == null || GameManager.Instance.economyManager == null)
            {
                Debug.Log("Economy manager not found.");
                return;
            }

            if (GameManager.Instance.economyManager.CanAfford(itemCost))
            {
                GameManager.Instance.economyManager.SpendMoney(itemCost);
                GameManager.Instance.playerNeedsController.EatFood(25f);
                Debug.Log("Player bought " + itemName + " for $" + itemCost);
            }
            else
            {
                Debug.Log("Not enough money to buy " + itemName);
            }
        }
    }
}
