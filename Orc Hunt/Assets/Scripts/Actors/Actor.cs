using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    [HideInInspector] public ActorData data;

    public virtual void Start()
    {
        GetActorData();
    }

    public virtual void GetActorData()
    {
        if (TryGetComponent<ActorData>(out ActorData _data))
        {
            data = _data;
        }
        else return;
    }
}
