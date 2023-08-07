using System;
using UnityEngine;

public class EnemyEvents
{
    public event Action<GameObject> SetTargetEvent;
    public void SetTarget(GameObject newTarget) => SetTargetEvent?.Invoke(newTarget);
}
