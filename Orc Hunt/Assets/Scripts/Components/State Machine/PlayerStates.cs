using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStates
{
    public static State idle = (State)Resources.Load("Data/States/Player/Idle");
    public static State moving = (State)Resources.Load("Data/States/Player/Moving");
}
