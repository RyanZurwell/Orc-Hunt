using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateController : StateController
{
    public IdleState idleState = new IdleState();
    public PlayerMovingState movingState = new PlayerMovingState();
}
