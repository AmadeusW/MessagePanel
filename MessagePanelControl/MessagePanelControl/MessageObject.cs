using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusW.MessagePanelControl
{
    public class MessageObject : BaseViewModel
    {
        readonly string _messageFormat;
        readonly string[] _messageParameters;
        readonly MessageKind _kind;
        bool _disappearing = false;

        public MessageObject(string messageBody, MessageKind kind)
        {
            _messageFormat = messageBody;
            _messageParameters = null;
            _kind = kind;
        }

        public MessageObject(string messageFormat, MessageKind kind, string messageParameter)
        {
            _messageFormat = messageFormat;
            _messageParameters = new String[] { messageParameter };
            _kind = kind;
        }

        public MessageObject(string messageFormat, MessageKind kind, string[] messageParameters)
        {
            _messageFormat = messageFormat;
            _messageParameters = messageParameters;
            _kind = kind;
        }

        public String MessageBody
        {
            get
            {
                // If there are no parameters, simply return the message. If there are any, use String.Format
                return _messageParameters == null ? _messageFormat :  String.Format(_messageFormat, _messageParameters);
            }
        }

        public MessageKind Kind
        {
            get
            {
                return _kind;
            }
        }

        internal bool Disappearing
        {
            get
            {
                return _disappearing;
            }
            set
            {
                _disappearing = value;
                NotifyPropertyChanged();
            }
        }
    }
}
