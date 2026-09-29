using System.Collections.Generic;
using UnityEngine;

namespace VortexLifeSim.Vehicles
{
    public class NPCVehicleTraffic : MonoBehaviour
    {
        public List<GameObject> vehicles = new List<GameObject>();
        public Vector3 routeDirection = new Vector3(1f, 0f, 0f);
        public float speed = 6f;

        private void Update()
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle == null)
                {
                    continue;
                }

                vehicle.transform.position += routeDirection * speed * Time.deltaTime;
            }
        }
    }
}
