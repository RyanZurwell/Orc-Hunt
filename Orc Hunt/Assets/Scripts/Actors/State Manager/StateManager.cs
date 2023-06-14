using UnityEngine;

public class StateManager : MonoBehaviour
{
    public IState currentState;

    public IdleState idle = new IdleState();

    public virtual void Start()
    {
        StartingState(idle);
    }

    private void Update()
    {
        currentState.OnUpdate();
    }

    private void FixedUpdate()
    {
        currentState.OnFixedUpdate();
    }

    public void StartingState(IState startState)
    {
        currentState = startState;
        SetupState();
        currentState.OnEnter();
    }

    public void ChangeState(IState newState)
    {
        currentState.OnExit();
        currentState = newState;
        SetupState();
        currentState.OnEnter();
    }

    private void SetupState()
    {
        currentState.SetOwner(this.gameObject);
        currentState.SetStateManager(this);
    }
}
