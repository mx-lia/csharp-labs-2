using LR_14_15.Composite;
using LR_14_15.Decorator;
using LR_14_15.State;
using System.Windows.Controls;

namespace LR_14_15.Models
{
    public class MyObject : Component, ISelectableObject
    {
        public IObjectState State { get; private set; }

        public MyObject(TextBlock block) : base(block)
        {
            State = new FlyingState();
        }

        public void ChangeState(IObjectState state)
        {
            State = state;
        }

        public void ShowState()
        {
            State.HandleInput(_block);
        }

        public void MoveTo(int x, int y)
        {
            _block.Text += $"MyObject move to {x}, {y}\n";
        }
    }
}
