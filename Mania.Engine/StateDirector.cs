using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Mania.Engine;

public class StateDirector<T> where T : State
{
    protected T CurrentState { get; set; }

    public virtual void TransitionToState(State nextState)
    {
        UnloadCurrentState();
        LoadNextState(nextState);
    }
    private void LoadNextState(State nextState)
    {
        CurrentState = (T)nextState;
        CurrentState.OnChangeState += TransitionToState;
        CurrentState.Enter();
    }
    private void UnloadCurrentState()
    {
        if (CurrentState != null)
        {
            CurrentState.Exit();
            CurrentState.OnChangeState -= TransitionToState;
        }
    }
}
