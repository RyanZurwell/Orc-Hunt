using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorComponent : MonoBehaviour
{
    [HideInInspector] public StatManager myStatManager;
    [HideInInspector] public Dictionary<Stat, float> myStats;
    [HideInInspector] public StatList stat;

    public virtual void Awake()
    {
        Initialize();
    }

    public virtual void Initialize()
    {
        GetStatManager();
        stat = (StatList)Resources.Load("Stat List");
    }

    private void GetStatManager()
    {
        if (TryGetComponent<StatManager>(out StatManager _statManager))
        {
            myStatManager = _statManager;
            myStats = _statManager.stats;
        }
        else
        {
            Debug.LogError("Could not find the stat manager.");
            return;
        }
    }
}
