using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    [HideInInspector] public StateController myState;
    [HideInInspector] public ActorData myData;
    [HideInInspector] public StatList stats;

    public virtual void Awake()
    {
        stats = (StatList)Resources.Load("Stat List");
    }

    public virtual void Start()
    {
        if (TryGetComponent<ActorData>(out ActorData data))
        {
            myData = data;
        }

        if (TryGetComponent<StateController>(out StateController stateController))
        {
            myState = stateController;
        }
    }
}
