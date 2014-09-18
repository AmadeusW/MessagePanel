using System;
using System.Windows.Input;

namespace AmadeusW.MessagePanelControl
{
    public class RemoveMessageCommand : ICommand
    {
        MessagePanelViewModel _viewModel;

        public RemoveMessageCommand(MessagePanelViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.RemoveMessage(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
