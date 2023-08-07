using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EnemyStates
{
    public static State Setup = (State)Resources.Load("Data/States/Enemy/Setup");
    public static State searching = (State)Resources.Load("Data/States/Enemy/Searching");
    public static State chasing = (State)Resources.Load("Data/States/Enemy/Chasing");
}
