using UnityEngine;

public class StateController
{
    public IState currentState;

    public void StartingState(IState startState, GameObject owner)
    {
        currentState = startState;
        currentState.SetOwner(owner);
        currentState.OnEnter();
    }

    public void ChangeState(IState newState, GameObject owner)
    {
        currentState.OnExit();
        currentState = newState;
        currentState.SetOwner(owner);
        currentState.OnEnter();
    }
}
