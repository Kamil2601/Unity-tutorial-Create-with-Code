using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float spawnPause = 3f;

    private float lastSpawnTime;

    void Start()
    {
        lastSpawnTime = -spawnPause - 1;    
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float spacePressTime = Time.time;
            Debug.Log(spacePressTime - lastSpawnTime);
            if (spacePressTime >= lastSpawnTime + spawnPause)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                lastSpawnTime = spacePressTime;
            }
        }
    }
}
