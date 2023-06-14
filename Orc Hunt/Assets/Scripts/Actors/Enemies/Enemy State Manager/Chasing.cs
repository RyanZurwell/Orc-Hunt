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
    }

    public override void OnUpdate()
    {
        controller.SetDestination(controller.target.transform.position);
    }
}
