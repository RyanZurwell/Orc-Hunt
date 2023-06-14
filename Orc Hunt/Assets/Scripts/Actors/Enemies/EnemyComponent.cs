using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyComponent : ActorComponent
{
    [HideInInspector] public EnemyStateManager myState;
    [HideInInspector] public EnemyController myController;

    public override void Initialize()
    {
        base.Initialize();
        GetEnemyStateManager();
        GetEnemyController();
    }

    private void GetEnemyStateManager()
    {
        if (TryGetComponent<EnemyStateManager>(out EnemyStateManager _stateManager))
        {
            myState = _stateManager;
        }
        else
        {
            Debug.LogError("Could not find the state manager.");
            return;
        }
    }

    private void GetEnemyController()
    {
        if (TryGetComponent<EnemyController>(out EnemyController _controller))
        {
            myController = _controller;
        }
        else
        {
            Debug.LogError("Could not find the controller.");
            return;
        }
    }
}
