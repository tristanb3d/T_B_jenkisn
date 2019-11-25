using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollision : MonoBehaviour
{
    public GameObject Spawner2;
    public float SpawnTimer2 = 10f;
    public float SpawnWait2 = 0.05f;
    public float SpawnLimit2;
    
    void Start()
    {
        InvokeRepeating("Spawn2", SpawnTimer2, SpawnWait2);
    }
    // Update is called once per frame
    void Spawn2()
    {
        SpawnLimit2 += 1;
        //  bool SpawnStop;
        if (SpawnLimit2 < 100)
        {
            Instantiate(Spawner2, transform.position, transform.rotation);
        }
    } 
}


