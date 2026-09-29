using UnityEngine;

namespace VortexLifeSim.Interaction
{
    public class InteractableObject : MonoBehaviour
    {
        public string objectName = "Object";
        public KeyCode interactionKey = KeyCode.E;
        public bool isInsideTrigger = false;

        private void Update()
        {
            if (!isInsideTrigger)
            {
                return;
            }

            if (Input.GetKeyDown(interactionKey))
            {
                Interact();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                isInsideTrigger = true;
                Debug.Log("Player is near: " + objectName);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                isInsideTrigger = false;
            }
        }

        public virtual void Interact()
        {
            Debug.Log("Interacted with " + objectName + " successfully.");
        }
    }
}
