using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class Data : MonoBehaviour
{
    [SerializeField] private StatTemplate template;
    [ShowInInspector] public Dictionary<Stat, float> stats = new Dictionary<Stat, float>();

    ////////////////////////////////////////////////
    /// Unity Methods
    ////////////////////////////////////////////////

    private void Awake()
    {
        CreateStats();
    }

    ////////////////////////////////////////////////
    /// Class Methods
    ////////////////////////////////////////////////

    private void CreateStats()
    {
        foreach (Stat stat in template.stats.Keys)
        {
            stats.Add(stat, template.stats[stat]);
        }
    }

    public void IncreaseStat(Stat stat, float value) => stats[stat] += value;
    public void DecreaseStat(Stat stat, float value) => stats[stat] -= value;
}
