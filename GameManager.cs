using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private StateMachine stateMachine;
    private GameStates gameState;
    private bool debug;

    void Awake () {
        instance = this;
        stateMachine = new StateMachine ();
        gameState = new GameStates (stateMachine, this);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        stateMachine.InitState (gameState.Idle ());
    }

    // Update is called once per frame
    void Update()
    {
        stateMachine.UpdateState ();

        if (Input.GetKeyDown (KeyCode.D)) {
            debug = !debug;
        }
    }

    void OnGUI () {
        if (debug) {
            string content = stateMachine != null ? stateMachine.currentState != null ? stateMachine.currentState.name : "no state" : "no state";
            GUILayout.Label ($"<color='black'><size=12> Game State: {content}</size></color>");
        }
    }
}
