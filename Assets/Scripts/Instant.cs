using UnityEngine;
using System.Collections;

public class Instant : MonoBehaviour
{
    public GameObject[] objectPrefabs; // Array to store different colored prefabs

    public float spawnInterval = 1f;
    public float spawnRadius = 5f;

    void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            // Select a random prefab
            int randomIndex = Random.Range(0, objectPrefabs.Length);
            GameObject prefabToSpawn = objectPrefabs[randomIndex];

            // Generate a random position within a radius
            Vector3 randomPosition = Random.insideUnitSphere * spawnRadius;
            randomPosition += transform.position;

            // Instantiate the prefab
            Instantiate(prefabToSpawn, randomPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}