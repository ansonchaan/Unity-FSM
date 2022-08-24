using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseState
{
    protected GameManager gameManager;

    public IdleState (StateMachine stateMachine, GameManager _gameManager) : base ("Idle", stateMachine) {
        gameManager = _gameManager;
    }

    public override void Enter () {

    }
}
