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

        if (target != null) myState.ChangeState(myState.chasing);
    }

    public void SetDestination(Vector3 destination)
    {
        agent.SetDestination(destination);
    }
}
