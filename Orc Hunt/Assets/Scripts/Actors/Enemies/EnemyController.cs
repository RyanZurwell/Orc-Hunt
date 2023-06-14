using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : EnemyComponent
{
    NavMeshAgent agent;

    public GameObject target;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        agent.speed = myStats[stat.movementSpeed];
    }

    private void Update()
    {
        if (myState.currentState == myState.idle && target != null) myState.ChangeState(myState.chasing);
    }

    public void SetDestination(Vector3 destination)
    {
        agent.SetDestination(destination);
    }
}
