using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Commands
{
    class MyCommands
    {
        private static RoutedUICommand reset;

        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.R, ModifierKeys.Control, "Ctrl + R"));
            reset = new RoutedUICommand("Reset", "Reset", typeof(MyCommands), inputs);
        }

        public static RoutedUICommand Reset
        {
            get { return reset; }
        }
    }
}
