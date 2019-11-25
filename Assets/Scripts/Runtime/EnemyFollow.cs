using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public GameObject Enm;
    //public GameObject Player;
    //move to position 
    public Vector3 vec3;
    public float movespeed = 5f;
    public Transform target;

    private void Start()
    {
        //  vec3 = transform.position - Enm.transform.position;
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        transform.LookAt(target.transform);
        transform.position += transform.forward * movespeed * Time.deltaTime;

    }



    //do  damage 
    //colider 
    //
    //Destroy(col.gameObject);

    void OnTriggerEnter(Collider coli)
    {
        //do dammage 
        if (coli.gameObject.CompareTag("Player"))
        {
            //Destroy(Player);
            Debug.Log("hito");

        }
        if (coli.gameObject.CompareTag("bullet"))
        {
            Destroy(Enm);
            Debug.Log("bulleto");

        }
    }

}
