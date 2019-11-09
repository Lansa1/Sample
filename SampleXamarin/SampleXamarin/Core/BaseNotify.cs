using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SampleXamarin.Core
{
    public abstract class BaseNotify : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(object obj, string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(obj, new PropertyChangedEventArgs(propName) );
        }

        public void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
