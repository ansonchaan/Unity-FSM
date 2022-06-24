
public abstract class BaseState
{
    public string name;
    protected StateMachine stateMachine;

    public BaseState(string _name, StateMachine _stateMachine) {
        name = _name;
        stateMachine = _stateMachine;
    }

    public virtual void Enter () { }
    public virtual void Update () { }
    public virtual void FixedUpdate () { }
    public virtual void Exit () { }
}
