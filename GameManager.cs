using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private StateMachine fsm;

    // Start is called before the first frame update
    void Start()
    {
        fsm = new StateMachine (new IdleState (fsm));
    }

    // Update is called once per frame
    void Update()
    {
        fsm.Update ();
    }

    void OnGUI () {
        string content = fsm != null ? fsm.currentState != null ? fsm.currentState.name : "no state" : "no state";
        GUILayout.Label ($"<color='black'><size=12> Game State: {content}</size></color>");
    }
}
