using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCFollower : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform player;
    [SerializeField] Vector3 sizeOfView;
    [SerializeField] LayerMask whatIsCharacter;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        FindCharacterToFollow();

        if (player == null) { return; }

        agent.SetDestination(player.position);
    }

    void FindCharacterToFollow()
    {
        if (player != null) { return; }

        var characters = Physics.OverlapBox(transform.position, sizeOfView, Quaternion.identity, whatIsCharacter);
        if (characters.Length > 0)
        {
            player = characters[0].transform;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, sizeOfView);
    }
}