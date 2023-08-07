using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : EntityComponent
{
    public State currentState;
    public State defaultState;
    public State[] states;

    ////////////////////////////////////////////////
    /// Unity Methods
    ////////////////////////////////////////////////

    private void Awake()
    {
        Initialize();
        InstantiateStates();
    }

    private void Start()
    {
        currentState = GetState(defaultState);
        currentState.Enter();
    }

    private void Update()
    {
        currentState.Update();
    }

    private void FixedUpdate()
    {
        currentState.FixedUpdate();
    }

    ////////////////////////////////////////////////
    /// Class Methods
    ////////////////////////////////////////////////

    public virtual void ChangeState(State newState)
    {
        newState = GetState(newState);

        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }

    private State GetState(State state)
    {
        State newState;

        foreach (State curState in states)
        {
            if (state.GetType() == curState.GetType())
            {
                newState = curState;
                return newState;
            }
        }

        return null;
    }

    private void InstantiateStates()
    {
        for (int i = 0; i < states.Length; i++)
        {
            State curState = states[i];
            curState = ScriptableObject.CreateInstance(states[i].GetType()) as State;
            curState.Setup(this, events, this.gameObject);
            states[i] = curState;
        }
    }
}
