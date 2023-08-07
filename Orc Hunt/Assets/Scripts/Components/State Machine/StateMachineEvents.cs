using System;

public class StateMachineEvents
{
    public event Action<IState> ChangeStateEvent;
    public void ChangeState(IState newState) => ChangeStateEvent?.Invoke(newState);
}
