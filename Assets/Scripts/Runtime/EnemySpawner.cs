using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject spawnPrefab;
    public float spawnTimer;
    public float spawnWait;
    public int spawnLimit;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnTimer, spawnWait);
    }

    // Update is called once per frame
    void Spawn()
    {
        //  bool SpawnStop;
        if (spawnLimit < 25)
        {
            Instantiate(spawnPrefab, transform.position, transform.rotation);
            spawnLimit += 1;
        }
    }
}
