using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationManager : AnimationManager
{
    private EnemyController controller;

    public override void Start()
    {
        base.Start();
        GetController();
    }

    void Update()
    {
        animator.SetFloat("Current X", GetMoveDirection().x);
        animator.SetFloat("Current Y", GetMoveDirection().y);
    }

    private void GetController()
    {
        if (TryGetComponent<EnemyController>(out EnemyController _controller))
        {
            controller = _controller;
        }
        else
        {
            Debug.LogError("Count not find the controller.");
            return;
        }
    }

    private Vector2 GetMoveDirection() => controller.target.transform.position - transform.position;
}
