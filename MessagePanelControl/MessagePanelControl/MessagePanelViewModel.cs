using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace AmadeusW.MessagePanelControl
{
    public class MessagePanelViewModel : BaseViewModel
    {
        ObservableCollection<MessageObject> _messages = new ObservableCollection<MessageObject>();
        public RemoveMessageCommand RemoveMessageCommand { get; set; }

        public MessagePanelViewModel()
        {
            RemoveMessageCommand = new RemoveMessageCommand(this);
        }

        public ObservableCollection<MessageObject> Messages
        {
            get
            {
                return _messages;
            }
            set
            {
                _messages = value;
                NotifyPropertyChanged();
            }
        }

        internal void RemoveMessage(object parameter)
        {
            var message = parameter as MessageObject;
            if (message != null)
            {
                // Trigger the move-out animation
                message.IsAlive = false;
                // Remove the element.
                // Storyboard.Completed event won't help because there is no reference as to what element got removed.
                // We need to implement something of our own
                Task.Run(() =>
                    {
                        Thread.Sleep(500);
                        acutallyRemoveMessageFromCollection(message);
                    }
                );
            }
        }

        private void acutallyRemoveMessageFromCollection(MessageObject message)
        {
            Application.Current.Dispatcher.BeginInvoke
                (System.Windows.Threading.DispatcherPriority.Normal,
                (Action)(() =>
                    {
                        Messages.Remove(message);
                    }
                ));
        }

        public void AddMessage(MessageObject newMessage)
        {
            Messages.Add(newMessage);
            newMessage.IsAlive = true;

            // TODO: Take care of duplicates
        }
    }
}
