using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Car
    {
        public enum State
        {
            Stopped,
            Started,
            Running,

        }
        public enum Action
        {
            Stop,
            Start,
            Accelerate,
        }
        private State SState=State.Stopped;

        public State currentState { get { return SState; } }

        public void TakeAction(Action action)
        {
            public void TakeAction(Action action)
            {
                SState = (SState, action) switch
                {
                    (State.Stopped, Action.Start) => State.Started,
                    (State.Started, Action.Accelerate) => State.Running,
                    (State.Started, Action.Stop) => State.Stopped,
                    (State.Running, Action.Stop) => State.Stopped,
                    _ => SState

                };
            }
    }
}
