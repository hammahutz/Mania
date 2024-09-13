using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mania.Engine;

public abstract class State
{
    public event Action<State> OnChangeState;
    public void ChangeState(State newState) => OnChangeState?.Invoke(newState);
    public abstract void Enter();
    public abstract void Exit();
}