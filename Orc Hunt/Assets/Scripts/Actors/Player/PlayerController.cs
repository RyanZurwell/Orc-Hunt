using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PlayerComponent
{
    private void FixedUpdate()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0) player.stateController.ChangeState(player.stateController.movingState, gameObject);
    }
}
