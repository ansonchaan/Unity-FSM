using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    public BaseState lastState;
    public BaseState currentState;

    public StateMachine (BaseState startState)
    {
        currentState = startState;
        currentState.Enter ();
    }

    public void Update()
    {
        if (currentState != null)
            currentState.Update ();
    }

    public void FixedUpdate ()
    {
        if (currentState != null)
            currentState.FixedUpdate ();
    }

    public void SwitchState (BaseState newState)
    {
        if(currentState != null)
            currentState.Exit ();

        lastState = currentState;
        currentState = newState;
        currentState.Enter ();
    }
}
