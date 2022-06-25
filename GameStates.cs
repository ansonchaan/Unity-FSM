
public class GameStates : StateMachine {
    StateMachine stateMachine;

    public GameStates (StateMachine _stateMachine) {
        stateMachine = _stateMachine;
    }

    public BaseState Idle () {
        return new IdleState (stateMachine);
    }

    //public BaseState Win () {
    //    return new WinState (stateMachine);
    //}

    //public BaseState End () {
    //    return new EndState (stateMachine);
    //}
}
