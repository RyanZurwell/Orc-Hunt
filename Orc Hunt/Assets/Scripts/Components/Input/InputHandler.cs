using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : EntityComponent
{
    private InputEvents inputEvents;

    ////////////////////////////////////////////////
    /// Unity Methods
    ////////////////////////////////////////////////

    private void Awake()
    {
        Initialize();
        inputEvents = events.character.player.input;
    }

    private void Update()
    {
        CheckMovementInput();

        if (Input.GetKeyDown(KeyCode.Q)) data.IncreaseStat(Stats.experience, 10);
        if (Input.GetKeyDown(KeyCode.E)) data.DecreaseStat(Stats.experience, 10);
    }

    ////////////////////////////////////////////////
    /// Input Handler Methods
    ////////////////////////////////////////////////

    private void CheckMovementInput()
    {
        if (Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Vertical")) inputEvents.MovementInputDown();
        else if (!Input.GetButton("Horizontal") && !Input.GetButton("Vertical") && state.currentState.GetType() == PlayerStates.moving.GetType()) inputEvents.MovementInputUp();
    }
}
