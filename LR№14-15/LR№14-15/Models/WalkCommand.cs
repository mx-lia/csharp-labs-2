using LR_14_15.Command;
using System.Windows.Controls;

namespace LR_14_15.Models
{
    public class WalkCommand : ICommand
    {
        public void Execute(TextBlock block)
        {
            Walk(block);
        }

        private void Walk(TextBlock block)
        {
            block.Text += "Walk.\n";
        }
    }
}
