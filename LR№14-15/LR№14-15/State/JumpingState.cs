using LR_14_15.Models;
using System.Windows.Controls;

namespace LR_14_15.State
{
    public class JumpingState : IObjectState
    {
        public void HandleInput(TextBlock block)
        {
            block.Text += $"Object is jumping.\n";
        }

        public void Update(MyObject myObject)
        {
            myObject.ChangeState(this);
        }
    }
}
