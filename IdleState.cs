using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseState
{
    public IdleState (StateMachine stateMachine) : base ("Idle", stateMachine) { }

    public override void Enter () {
    }
}
