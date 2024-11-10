using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quantity : MonoBehaviour
{
    public Slider slide;
    public BalloonSpawn Spawn;

    // Update is called once per frame
    void Update()
    {
        Spawn.SpawnRate = slide.value+ 1;
    }
}
