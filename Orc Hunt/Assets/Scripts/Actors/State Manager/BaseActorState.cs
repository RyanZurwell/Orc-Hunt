using UnityEngine;

public class BaseActorState : IState
{
    [HideInInspector] public GameObject owner;
    [HideInInspector] public StateManager state;
    
    public void SetOwner(GameObject _owner) => owner = _owner;
    public void SetStateManager(StateManager stateManager) => state = stateManager;

    public virtual void OnEnter()
    {
        
    }

    public virtual void OnUpdate()
    {

    }

    public virtual void OnFixedUpdate()
    {

    }

    public virtual void OnExit()
    {

    }
}
