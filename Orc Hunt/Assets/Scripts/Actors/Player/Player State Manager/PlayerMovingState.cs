using UnityEngine;

public class PlayerMovingState : MovingState
{
    private PlayerController controller;

    public override void OnEnter()
    {
        base.OnEnter();
        if (owner.TryGetComponent<PlayerController>(out PlayerController _controller))
        {
            controller = _controller;
        }
        else
        {
            Debug.LogError("Could not find the player controller.");
            state.ChangeState(state.idle);
        }

        owner.GetComponent<AnimationManager>().PlayMovingAnimation();
    }

    public override void OnFixedUpdate()
    {
        controller.Moving();
    }

    public override void OnExit()
    {
        base.OnExit();
        owner.GetComponent<AnimationManager>().StopMovingAnimation();
    }
}
