using UnityEngine;

public class GameManager : MonoBehaviour
{
    private StateMachine stateMachine;
    private GameStates gameState;

    // Start is called before the first frame update
    void Start()
    {
        stateMachine = new StateMachine ();
        gameState = new GameStates (stateMachine);
        stateMachine.InitState (gameState.Idle ());
    }

    // Update is called once per frame
    void Update()
    {
        stateMachine.UpdateState ();
    }

    void OnGUI () {
        string content = stateMachine != null ? stateMachine.currentState != null ? stateMachine.currentState.name : "no state" : "no state";
        GUILayout.Label ($"<color='black'><size=12> Game State: {content}</size></color>");
    }
}
