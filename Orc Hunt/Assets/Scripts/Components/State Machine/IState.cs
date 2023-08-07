using UnityEngine;

public interface IState
{
    void Setup(StateMachine state, EventHandler events, GameObject owner);
    void AddListeners();
    void Enter();
    void Update();
    void FixedUpdate();
    void Exit();
}
