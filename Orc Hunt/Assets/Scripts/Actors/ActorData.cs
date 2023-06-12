using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorData : MonoBehaviour
{
    [SerializeField] private StatSheet statSheet;

    public Dictionary<Stat, float> stats = new Dictionary<Stat, float>();

    private void Start()
    {
        CreateStats();
    }

    private void CreateStats()
    {
        if (statSheet == null) return;

        foreach (Stat stat in statSheet.stats.Keys)
        {
            if (stats.ContainsKey(stat)) continue;

            stats.Add(stat, statSheet.stats[stat]);
        }
    }
}
