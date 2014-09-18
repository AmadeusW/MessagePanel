using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmadeusW.MessagePanelControl;

namespace AmadeusW.MessagePanelDemoApp
{
    public class DemoViewModel : BaseViewModel
    {
        public MessagePanelViewModel MessagePanel { get; set; } 

        public DemoViewModel()
        {
            MessagePanel = new MessagePanelViewModel();
            CreateNewMessageCommand = new CreateNewMessageCommand(this);

            MessagePanel.Messages.Add(new MessageObject("Fatal", MessagePanelControl.MessageKind.Fatal));
            MessagePanel.Messages.Add(new MessageObject("Error", MessagePanelControl.MessageKind.Error));
            MessagePanel.Messages.Add(new MessageObject("Warning", MessagePanelControl.MessageKind.Warning));
            MessagePanel.Messages.Add(new MessageObject("Info", MessagePanelControl.MessageKind.Info));
            MessagePanel.Messages.Add(new MessageObject("Success", MessagePanelControl.MessageKind.Success));
            MessagePanel.Messages.Add(new MessageObject("Success", MessagePanelControl.MessageKind.Success));
            MessagePanel.Messages.Add(new MessageObject("Success", MessagePanelControl.MessageKind.Success));
        }

        #region XAML Binding

        public CreateNewMessageCommand CreateNewMessageCommand { get; set; }
        public String MessageFormat { get; set; }
        public String MessageParam1 { get; set; }
        public String MessageParam2 { get; set; }
        public String MessageKind { get; set; }

        #endregion

        internal void CreateNewMessage()
        {
            MessageObject newMessage;
            MessageKind newMessageKind;
            Enum.TryParse<AmadeusW.MessagePanelControl.MessageKind>(MessageKind, out newMessageKind);
            
            if (!String.IsNullOrEmpty(MessageParam2))
            {
                string[] messageParams = new string[] { MessageParam1, MessageParam2 };
                newMessage = new MessageObject(MessageFormat, newMessageKind, messageParams);
            }
            else if (!String.IsNullOrEmpty(MessageParam1))
            {
                newMessage = new MessageObject(MessageFormat, newMessageKind, MessageParam1);
            }
            else
            {
                newMessage = new MessageObject(MessageFormat, newMessageKind);
            }

            MessagePanel.Messages.Add(newMessage);
        }
    }
}
