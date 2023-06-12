using UnityEngine;

public interface IState
{
    public void SetOwner(GameObject owner);
    public void OnEnter();
    public void OnUpdate();
    public void OnFixedUpdate();
    public void OnExit();
}
