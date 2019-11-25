using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIFollow : MonoBehaviour
{
    public int speed;

    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Update()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        agent.SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);
    }
}
