using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{
    IState currentState;

    public MovingState movingState = new MovingState();
    public AttackingState attackingState = new AttackingState();
    public CrowdControlledState crowdControlledState = new CrowdControlledState();

    private void Update()
    {
        currentState.OnUpdate();
    }

    public void ChangeState(IState newState)
    {
        currentState.OnExit();
        currentState = newState;
        currentState.OnEnter();
    }
}
