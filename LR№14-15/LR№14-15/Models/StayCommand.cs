using LR_14_15.Command;
using System.Windows.Controls;

namespace LR_14_15.Models
{
    public class StayCommand : ICommand
    {
        public void Execute(TextBlock block)
        {
            Stay(block);
        }

        private void Stay(TextBlock block)
        {
            block.Text += "Stay.\n";
        }
    }
}
