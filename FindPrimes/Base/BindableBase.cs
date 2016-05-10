using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace FindPrimes.Base
{
    public abstract class BindableBase : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] String propertyName = null)
        {
            if (Equals(storage, value))
            {
                return false;
            }
            storage = value;
            this.NotifyPropertyChanged(new PropertyChangedEventArgs(propertyName));
            return true;
        }

        protected bool SetProperty<T>(T value, Func<T> getter, Action<T> setter, [CallerMemberName] String propertyName = null)
        {
            if (object.Equals(getter, value))
                return false;

            setter(value);
            this.NotifyPropertyChanged(new PropertyChangedEventArgs(propertyName));
            return true;
        }

        public void NotifyPropertyChanged(PropertyChangedEventArgs e)
        {
            // get handler (usually a local event variable or just the event)
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, e);
            }
        }
    }
}
