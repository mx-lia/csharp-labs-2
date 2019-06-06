using LR_14_15.Models;
using System.Windows.Controls;

namespace LR_14_15.State
{
    public interface IObjectState
    {
        void HandleInput(TextBlock block);
        void Update(MyObject myObject);
    }
}
