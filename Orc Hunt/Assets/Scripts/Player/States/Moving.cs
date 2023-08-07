using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/States/Moving", fileName = "Moving")]
public class Moving : State
{
    Rigidbody2D rigidbody;
    Animator animator;

    ////////////////////////////////////////////////
    /// IState Methods
    ////////////////////////////////////////////////

    public override void AddListeners()
    {
        events.character.player.input.MovementInputUpEvent += OnMovementStop;
    }

    public override void Enter()
    {
        if (owner.TryGetComponent<Rigidbody2D>(out Rigidbody2D _rigidbody))
        {
            rigidbody = _rigidbody;
        }

        animator = owner.GetComponentInChildren<Animator>();

        animator.SetBool(PlayParameters.moving, true);
    }

    public override void Update()
    {
        animator.SetFloat(FloatParameters.MoveX, MovementDirection().x);
        animator.SetFloat(FloatParameters.MoveY, MovementDirection().y);
    }

    public override void FixedUpdate()
    {
        Vector3 moveDir = MovementDirection();
        moveDir.Normalize();

        rigidbody.MovePosition(owner.transform.position + moveDir * 5 * Time.deltaTime);
    }

    public override void Exit()
    {
        animator.SetBool(PlayParameters.moving, false);
    }

    private Vector3 MovementDirection() => new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

    ////////////////////////////////////////////////
    /// Event Listener Methods
    ////////////////////////////////////////////////

    private void OnMovementStop() => state.ChangeState(PlayerStates.idle);
}
