using UnityEngine;

/// <summary>
/// Controls the movement of the actor.
/// </summary>

public class MovingState : IState
{
    public GameObject owner;

    public Rigidbody2D rb;

    public void SetOwner(GameObject _owner) => owner = _owner;

    public virtual void OnEnter()
    {
        rb = owner.GetComponent<Rigidbody2D>();
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
