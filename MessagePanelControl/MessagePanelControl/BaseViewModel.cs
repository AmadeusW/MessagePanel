using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AmadeusW.MessagePanelControl
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies the framework that the property has changed.
        /// This will update the view.
        /// 
        /// In most cases, leave the parameter blank;
        ///  it's assigned automatically through CallerMemberName attribute
        ///  when this method is called from within the setter of a property.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}