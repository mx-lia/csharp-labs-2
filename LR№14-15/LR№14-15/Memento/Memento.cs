using LR_14_15.Models;
using LR_14_15.State;

namespace LR_14_15.Memento
{
    public class Memento
    {
        public IObjectState State { get; set; }
        public Memento(MyObject myObject)
        {
            State = myObject.State;
        }

        public void Restorer(ref MyObject myObject)
        {
            myObject.ChangeState(State);
        }
    }
}
