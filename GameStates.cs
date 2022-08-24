
public class GameStates : StateMachine {
    StateMachine stateMachine;
    GameManager gameManager;

    public GameStates (StateMachine _stateMachine, GameManager _gameManager) {
        stateMachine = _stateMachine;
        gameManager = _gameManager;
    }

    public BaseState Idle () {
        return new IdleState (stateMachine, gameManager);
    }

    //public BaseState Win () {
    //    return new WinState (stateMachine);
    //}

    //public BaseState End () {
    //    return new EndState (stateMachine);
    //}
}
