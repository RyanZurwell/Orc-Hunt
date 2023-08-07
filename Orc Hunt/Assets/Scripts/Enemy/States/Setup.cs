using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(menuName = "Data/States/Enemy/Setup", fileName = "Setup")]
public class Setup : State
{
    private NavMeshAgent agent;

    public override void Enter()
    {
        if (owner.TryGetComponent<NavMeshAgent>(out NavMeshAgent _agent)) agent = _agent;
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        state.ChangeState(EnemyStates.searching);
    }
}
