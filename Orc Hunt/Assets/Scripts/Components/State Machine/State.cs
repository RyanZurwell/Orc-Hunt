using UnityEngine;

public class State : ScriptableObject, IState
{
    [HideInInspector] public StateMachine state;
    [HideInInspector] public EventHandler events;
    [HideInInspector] public GameObject owner;

    public void Setup(StateMachine _state, EventHandler _events, GameObject _owner)
    {
        state = _state;
        events = _events;
        owner = _owner;
        AddListeners();
    }

    public virtual void AddListeners()
    {

    }

    public virtual void Enter()
    {

    }

    public virtual void Update()
    {

    }

    public virtual void FixedUpdate()
    {

    }

    public virtual void Exit()
    {

    }
}
