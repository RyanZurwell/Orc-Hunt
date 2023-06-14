using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatManager : MonoBehaviour
{
    [SerializeField] private StatTemplate template;

    public Dictionary<Stat, float> stats = new Dictionary<Stat, float>();

    private void Awake()
    {
        CreateStats();
    }

    private void CreateStats()
    {
        if (template == null) return;

        foreach (Stat stat in template.stats.Keys)
        {
            if (stats.ContainsKey(stat)) continue;

            stats.Add(stat, template.stats[stat]);
        }
    }
}
