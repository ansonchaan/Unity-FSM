
public class StateMachine
{
    public BaseState lastState;
    public BaseState currentState;

    public void InitState (BaseState startState)
    {
        currentState = startState;
        currentState.Enter ();
    }

    public void UpdateState()
    {
        if (currentState != null)
            currentState.Update ();
    }

    public void FixedUpdateState ()
    {
        if (currentState != null)
            currentState.FixedUpdate ();
    }

    public void SwitchState (BaseState newState)
    {
        if(currentState != null)
            currentState.Exit ();

        newState.Enter ();

        lastState = currentState;
        currentState = newState;
    }
}
