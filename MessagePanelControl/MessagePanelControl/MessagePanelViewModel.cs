using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusW.MessagePanelControl
{
    internal class MessagePanelViewModel : BaseViewModel
    {
        ObservableCollection<MessageObject> _messages = new ObservableCollection<MessageObject>();

        ObservableCollection<MessageObject> Messages
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
    }
}
