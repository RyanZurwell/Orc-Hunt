using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Actor
{
    public PlayerStateController stateController;

    private void Awake()
    {
        stateController = new PlayerStateController();
    }

    public override void Start()
    {
        base.Start();
        stateController.StartingState(stateController.idleState, gameObject);
    }

    private void Update()
    {
        stateController.currentState.OnUpdate();
    }

    private void FixedUpdate()
    {
        stateController.currentState.OnFixedUpdate();
    }
}
