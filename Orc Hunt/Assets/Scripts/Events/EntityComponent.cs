using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityComponent : MonoBehaviour
{
    [HideInInspector] public EventHandler events;
    [HideInInspector] public StateMachine state;
    [HideInInspector] public Data data;

    public void Initialize()
    {
        if (transform.root.TryGetComponent<EventHandler>(out EventHandler _events)) events = _events;
        else
        {
            Debug.LogError("Could not find the event handler.");
            return;
        }

        if (transform.root.TryGetComponent<StateMachine>(out StateMachine _state)) state = _state;
        else
        {
            Debug.LogError("Could not find the state machine.");
            return;
        }

        if (transform.root.TryGetComponent<Data>(out Data _data)) data = _data;
        else
        {
            Debug.LogError("Could not find the state machine.");
            return;
        }

        AddListeners();
    }

    public virtual void AddListeners()
    {

    }
}
