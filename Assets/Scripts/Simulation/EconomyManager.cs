using UnityEngine;
using VortexLifeSim.Core;

namespace VortexLifeSim.Simulation
{
    public class EconomyManager : MonoBehaviour
    {
        public int buyItemCost = 20;

        public bool CanAfford(int cost)
        {
            if (GameManager.Instance == null || GameManager.Instance.playerStats == null)
            {
                return false;
            }

            return GameManager.Instance.playerStats.money >= cost;
        }

        public void SpendMoney(int amount)
        {
            if (GameManager.Instance == null || GameManager.Instance.playerStats == null)
            {
                return;
            }

            if (!CanAfford(amount))
            {
                Debug.Log("Not enough money to complete purchase.");
                return;
            }

            GameManager.Instance.playerStats.money -= amount;
            Debug.Log("Purchase complete. Remaining money: " + GameManager.Instance.playerStats.money);
        }

        public void EarnMoney(int amount)
        {
            if (GameManager.Instance == null || GameManager.Instance.playerStats == null)
            {
                return;
            }

            GameManager.Instance.playerStats.money += amount;
        }
    }
}
