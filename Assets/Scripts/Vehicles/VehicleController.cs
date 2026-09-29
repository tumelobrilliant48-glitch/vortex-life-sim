using UnityEngine;

namespace VortexLifeSim.Vehicles
{
    public class VehicleController : MonoBehaviour
    {
        public float acceleration = 18f;
        public float maxSpeed = 22f;
        public float turnSpeed = 110f;
        public float brakeForce = 25f;
        public float fuel = 100f;
        public float fuelBurnRate = 1.8f;
        public float maxFuel = 100f;
        public bool isOwnedByPlayer = true;
        public string vehicleModel = "Toyota Starter";

        private Rigidbody rb;
        private float steeringInput;
        private float throttleInput;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            if (rb == null)
            {
                return;
            }

            steeringInput = Input.GetAxis("Horizontal");
            throttleInput = Input.GetAxis("Vertical");

            if (fuel <= 0f)
            {
                throttleInput = 0f;
            }
        }

        private void FixedUpdate()
        {
            if (rb == null)
            {
                return;
            }

            float speed = Vector3.Dot(rb.velocity, transform.forward);

            if (Mathf.Abs(speed) < maxSpeed && throttleInput != 0f && fuel > 0f)
            {
                rb.AddForce(transform.forward * throttleInput * acceleration * 40f, ForceMode.Acceleration);
                fuel = Mathf.Max(0f, fuel - Mathf.Abs(throttleInput) * fuelBurnRate * Time.fixedDeltaTime);
            }

            if (throttleInput == 0f)
            {
                rb.velocity *= 0.99f;
            }

            Quaternion turnRotation = Quaternion.Euler(0f, steeringInput * turnSpeed * Time.fixedDeltaTime, 0f);
            rb.MoveRotation(rb.rotation * turnRotation);
        }

        public void Refuel(float amount)
        {
            fuel = Mathf.Clamp(fuel + amount, 0f, maxFuel);
        }

        public void Repair(float amount)
        {
            // placeholder for vehicle health repair later
            Debug.Log("Vehicle repaired by: " + amount);
        }
    }
}
