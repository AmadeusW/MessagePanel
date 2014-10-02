using System;
using System.Windows.Input;

namespace AmadeusW.MessagePanelDemoApp
{
    public class CreateNewMessageCommand : ICommand
    {
        DemoViewModel _demoViewModel;

        public CreateNewMessageCommand(DemoViewModel demoViewModel)
        {
            _demoViewModel = demoViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter != null && parameter.ToString() == "demo")
            {
                _demoViewModel.Demo();
            }
            else
            {
                _demoViewModel.CreateNewMessage();
            }
        }

        public event EventHandler CanExecuteChanged;
    }
}
