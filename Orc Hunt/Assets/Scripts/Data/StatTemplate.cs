using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(menuName = "Data/Stats/Template")]
public class StatTemplate : SerializedScriptableObject
{
    public Dictionary<Stat, float> stats = new Dictionary<Stat, float>();
}
