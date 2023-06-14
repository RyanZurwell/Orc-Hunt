using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComponent : ActorComponent
{
    [HideInInspector] public PlayerStateManager myState;
    [HideInInspector] public PlayerController myController;

    public override void Initialize()
    {
        base.Initialize();
        GetPlayerStateManager();
        GetPlayerController();
    }

    private void GetPlayerStateManager()
    {
        if (TryGetComponent<PlayerStateManager>(out PlayerStateManager _stateManager))
        {
            myState = _stateManager;
        }
        else
        {
            Debug.LogError("Could not find the state manager.");
            return;
        }
    }

    private void GetPlayerController()
    {
        if (TryGetComponent<PlayerController>(out PlayerController _controller))
        {
            myController = _controller;
        }
        else
        {
            Debug.LogError("Could not find the player controller.");
            return;
        }
    }
}
