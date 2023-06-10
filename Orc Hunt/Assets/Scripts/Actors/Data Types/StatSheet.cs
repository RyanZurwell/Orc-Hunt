using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu]
public class StatSheet : SerializedScriptableObject
{
    [ShowInInspector]
    public Dictionary<Stat, float> stats = new Dictionary<Stat, float>();
}
