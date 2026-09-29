using UnityEngine;

namespace VortexLifeSim.Core
{
    public class PlayerController : MonoBehaviour
    {
        public float moveSpeed = 5f;
        public float sprintSpeed = 8f;

        private CharacterController controller;
        private Vector3 velocity;

        private void Awake()
        {
            controller = GetComponent<CharacterController>();
        }

        private void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 move = transform.right * horizontal + transform.forward * vertical;
            float speed = Input.GetKey(KeyCode.LeftShift) ? sprintSpeed : moveSpeed;

            controller.Move(move * speed * Time.deltaTime);

            if (controller.isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }

            velocity.y += Physics.gravity.y * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }
    }
}
