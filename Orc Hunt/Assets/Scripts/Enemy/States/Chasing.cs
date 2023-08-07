using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(menuName = "Data/States/Enemy/Chasing", fileName = "Chasing")]
public class Chasing : State
{
    private GameObject target;
    private Animator animator;
    private NavMeshAgent agent;

    public override void AddListeners()
    {
        events.character.enemy.SetTargetEvent += SetTarget;
    }

    public override void Enter()
    {
        if (owner.TryGetComponent<NavMeshAgent>(out NavMeshAgent _agent)) agent = _agent;
        animator = owner.GetComponentInChildren<Animator>();

        animator.SetBool(PlayParameters.moving, true);
    }

    public override void Update()
    {
        agent.SetDestination(target.transform.position);
        animator.SetFloat(FloatParameters.MoveX, EnemyMoveDirection().x);
        animator.SetFloat(FloatParameters.MoveY, EnemyMoveDirection().y);

        if (target == null) state.ChangeState(EnemyStates.searching);
    }

    public override void Exit()
    {
        animator.SetBool(PlayParameters.moving, false);
    }

    private Vector2 EnemyMoveDirection()
    {
        Vector2 moveDir;
        moveDir = target.transform.position - state.gameObject.transform.position;
        moveDir.Normalize();
        return moveDir;
    }

    private void SetTarget(GameObject newTarget) => target = newTarget;
}
