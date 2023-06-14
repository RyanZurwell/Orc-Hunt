using UnityEngine;

public class Chasing : BaseActorState
{
    private EnemyController controller;

    public override void OnEnter()
    {
        if (owner.TryGetComponent<EnemyController>(out EnemyController _controller))
        {
            controller = _controller;
        }
        else
        {
            Debug.LogError("Could not find the controller");
            state.ChangeState(state.idle);
        }

        owner.GetComponent<AnimationManager>().PlayMovingAnimation();
    }

    public override void OnUpdate()
    {
        controller.SetDestination(controller.target.transform.position);
    }

    public override void OnExit()
    {
        base.OnExit();
        owner.GetComponent<AnimationManager>().StopMovingAnimation();
    }
}
