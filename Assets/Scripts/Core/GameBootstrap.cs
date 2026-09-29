using UnityEngine;

namespace VortexLifeSim.Core
{
    public class GameBootstrap : MonoBehaviour
    {
        public GameObject playerPrefab;
        public GameObject villageRoot;

        private void Start()
        {
            if (villageRoot == null)
            {
                villageRoot = new GameObject("VillageRoot");
            }

            if (playerPrefab == null)
            {
                CreateDefaultPlayer();
            }
            else
            {
                Instantiate(playerPrefab, new Vector3(-5f, 1f, -5f), Quaternion.identity, villageRoot.transform);
            }

            if (GameManager.Instance != null)
            {
                GameManager.Instance.playerObject = GameObject.FindGameObjectWithTag("Player");
                if (GameManager.Instance.playerObject != null)
                {
                    GameManager.Instance.playerNeedsController = GameManager.Instance.playerObject.GetComponent<PlayerNeedsController>();
                }
            }
        }

        private void CreateDefaultPlayer()
        {
            var player = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            player.name = "Player";
            player.tag = "Player";
            player.transform.position = new Vector3(-5f, 1f, -5f);
            player.transform.SetParent(villageRoot.transform);

            var controller = player.AddComponent<CharacterController>();
            controller.height = 2f;
            controller.radius = 0.5f;
            controller.center = new Vector3(0f, 1f, 0f);

            player.AddComponent<PlayerController>();
            player.AddComponent<PlayerNeedsController>();
        }
    }
}
