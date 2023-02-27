using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class moveEnemy : MonoBehaviour
{
    // Start is called before the first frame update

    private NavMeshAgent navMeshAgent;
    private GameObject player;
    
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(player.transform.position);
    }
}
