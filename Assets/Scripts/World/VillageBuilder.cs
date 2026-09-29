using System.Collections.Generic;
using UnityEngine;

namespace VortexLifeSim.World
{
    public class VillageBuilder : MonoBehaviour
    {
        public int buildingCount = 12;
        public Vector3 spacing = new Vector3(12f, 0f, 12f);
        public Vector3 origin = Vector3.zero;

        public void GenerateVillage()
        {
            ClearExistingVillage();

            GameObject root = new GameObject("VillageRoot");
            root.transform.SetParent(transform);

            GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
            ground.name = "VillageGround";
            ground.transform.SetParent(root.transform);
            ground.transform.localScale = new Vector3(6f, 1f, 6f);
            ground.transform.position = new Vector3(0f, 0f, 0f);

            GameObject road = GameObject.CreatePrimitive(PrimitiveType.Cube);
            road.name = "MainRoad";
            road.transform.SetParent(root.transform);
            road.transform.localScale = new Vector3(60f, 0.2f, 8f);
            road.transform.position = new Vector3(0f, 0.1f, 0f);

            GameObject crossRoad = GameObject.CreatePrimitive(PrimitiveType.Cube);
            crossRoad.name = "CrossRoad";
            crossRoad.transform.SetParent(root.transform);
            crossRoad.transform.localScale = new Vector3(8f, 0.2f, 60f);
            crossRoad.transform.position = new Vector3(0f, 0.1f, 0f);

            for (int i = 0; i < buildingCount; i++)
            {
                GameObject building = GameObject.CreatePrimitive(PrimitiveType.Cube);
                building.name = "Building_" + i;
                building.transform.SetParent(root.transform);
                building.transform.localScale = new Vector3(Random.Range(4f, 10f), Random.Range(3f, 12f), Random.Range(4f, 10f));

                Vector3 pos = origin + new Vector3(
                    (i % 4) * spacing.x,
                    0f,
                    (i / 4) * spacing.z
                );

                building.transform.position = pos + new Vector3(0f, building.transform.localScale.y / 2f, 0f);

                GameObject marker = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                marker.name = "Marker_" + i;
                marker.transform.SetParent(building.transform);
                marker.transform.localScale = new Vector3(0.5f, 0.2f, 0.5f);
                marker.transform.position = new Vector3(0f, building.transform.localScale.y + 1.2f, 0f);
                marker.GetComponent<Renderer>().material.color = Color.yellow;
            }

            GameObject spawnPoint = new GameObject("PlayerSpawnPoint");
            spawnPoint.transform.SetParent(root.transform);
            spawnPoint.transform.position = new Vector3(-5f, 1f, -5f);
        }

        private void ClearExistingVillage()
        {
            Transform child = transform.Find("VillageRoot");
            if (child != null)
            {
                DestroyImmediate(child.gameObject);
            }
        }

        private void DestroyImmediate(GameObject go)
        {
            if (Application.isPlaying)
            {
                Destroy(go);
            }
            else
            {
                DestroyImmediate(go);
            }
        }
    }
}
