using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [SerializeField] private StatSheet statSheet;

    private Dictionary<Stat, float> stats = new Dictionary<Stat, float>();

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
