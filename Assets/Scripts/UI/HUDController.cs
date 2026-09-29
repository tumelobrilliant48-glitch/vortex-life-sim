using UnityEngine;
using UnityEngine.UI;
using VortexLifeSim.Core;
using VortexLifeSim.World;

namespace VortexLifeSim.UI
{
    public class HUDController : MonoBehaviour
    {
        public Text hungerText;
        public Text thirstText;
        public Text hygieneText;
        public Text healthText;
        public Text moneyText;
        public Text timeText;

        private void Update()
        {
            if (GameManager.Instance == null || GameManager.Instance.playerStats == null)
            {
                return;
            }

            var stats = GameManager.Instance.playerStats;
            if (hungerText != null) hungerText.text = "Hunger: " + Mathf.RoundToInt(stats.hunger) + "%";
            if (thirstText != null) thirstText.text = "Thirst: " + Mathf.RoundToInt(stats.thirst) + "%";
            if (hygieneText != null) hygieneText.text = "Hygiene: " + Mathf.RoundToInt(stats.hygiene) + "%";
            if (healthText != null) healthText.text = "Health: " + Mathf.RoundToInt(stats.health) + "%";
            if (moneyText != null) moneyText.text = "Money: $" + stats.money;

            if (GameManager.Instance.timeCycle != null)
            {
                var time = GameManager.Instance.timeCycle;
                if (timeText != null)
                {
                    timeText.text = time.GetTimeLabel();
                }
            }
        }
    }
}
