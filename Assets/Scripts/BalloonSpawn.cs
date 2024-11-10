using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawn : MonoBehaviour
{
    public float MinX, MaxX;
    public GameObject[] Balloon;
    public float MaxTime;
    float CurrentTime = 0;
    public float SpawnRate = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime += Time.deltaTime;
        if (CurrentTime >= MaxTime / SpawnRate)
        {
            CurrentTime = 0;
            Instantiate(Balloon[Random.Range(0, Balloon.Length)], new Vector3(Random.Range(MinX, MaxX), this.transform.position.y, 0), Quaternion.identity);
        }
    }
}