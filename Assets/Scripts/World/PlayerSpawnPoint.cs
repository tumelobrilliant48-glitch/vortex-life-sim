using UnityEngine;

namespace VortexLifeSim.World
{
    public class PlayerSpawnPoint : MonoBehaviour
    {
        public Vector3 spawnPosition = new Vector3(-5f, 1f, -5f);

        private void Awake()
        {
            if (GameManager.Instance != null && GameManager.Instance.playerObject != null)
            {
                GameManager.Instance.playerObject.transform.position = spawnPosition;
            }
        }
    }
}
