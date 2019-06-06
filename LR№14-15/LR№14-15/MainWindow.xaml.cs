using LR_14_15.Adapter;
using LR_14_15.Command;
using LR_14_15.Composite;
using LR_14_15.Models;
using LR_14_15.State;
using System.Windows;
using System.Windows.Controls;

namespace LR_14_15
{
    public partial class MainWindow : Window
    {
        private readonly MyObject _myObject;

        private bool _flag;
        public MainWindow()
        {
            InitializeComponent();
            _myObject = new MyObject(ExampleBlock);
            _flag = false;
        }

        private void ShowWork(object sender, RoutedEventArgs e)
        {
            ICommand command = new StayCommand();
            command.Execute(ExampleBlock);
            command = new WalkCommand();
            command.Execute(ExampleBlock);
        }

        private void ShowObjectState(object sender, RoutedEventArgs e)
        {
            _myObject.ShowState();
        }

        private void ChangeObjectState(object sender, RoutedEventArgs e)
        {
            IObjectState objectState;
            if (_flag)
                objectState = new FlyingState();
            else
            {
                objectState = new JumpingState();
            }

            _flag = !_flag;
            _myObject.ChangeState(objectState);
            ExampleBlock.Text += "State changed.\n";
        }

        private void Move(object sender, RoutedEventArgs e)
        {
            switch((sender as Button).Content)
            {
                case "Move unit":
                    _myObject.MoveTo(1, 1);
                    break;
                case "Move squad":
                    var squad = new Squad(ExampleBlock);
                    squad.Add(new MyObject(ExampleBlock));
                    squad.Add(new MyObject(ExampleBlock));
                    ISelectableObject obj = new ISecondbjectToISelectableAdapter(new MySecondObject(ExampleBlock));
                    squad.Add(obj);
                    squad.MoveTo(10, 10);
                    break;
            }
        }
    }
}
