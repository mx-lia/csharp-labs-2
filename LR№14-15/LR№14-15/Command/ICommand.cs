using System.Windows.Controls;

namespace LR_14_15.Command
{
    public interface ICommand
    {
        void Execute(TextBlock block);
    }
}
