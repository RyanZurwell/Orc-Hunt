using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{
    public IState currentState;

    public IdleState idleState = new IdleState();
    public MovingState movingState = new MovingState();
    public AttackingState attackingState = new AttackingState();
    public CrowdControlledState crowdControlledState = new CrowdControlledState();

    private void Start()
    {
        currentState = idleState;
    }

    private void Update()
    {
        currentState.OnUpdate();

        if (Input.GetKeyDown(KeyCode.Q)) ChangeState(crowdControlledState);
    }

    public void ChangeState(IState newState)
    {
        currentState.OnExit();
        currentState = newState;
        currentState.OnEnter();
    }
}
