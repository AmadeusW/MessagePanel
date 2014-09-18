using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusW.MessagePanelControl
{
    public class MessagePanelViewModel : BaseViewModel
    {
        ObservableCollection<MessageObject> _messages = new ObservableCollection<MessageObject>();

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
    }
}
