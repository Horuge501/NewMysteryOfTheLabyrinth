using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NPCAgent : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform destination;

    void Start()
    {
        agent.SetDestination(destination.position);
    }

    void Update()
    {
        
    }
}
