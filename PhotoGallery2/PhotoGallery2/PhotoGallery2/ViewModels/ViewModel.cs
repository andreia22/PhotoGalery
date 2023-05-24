using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace PhotoGallery2.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void set<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)

        {
            if ( ! EqualityComparer<T>.Default.Equals(field, newValue))

            {
                field = newValue;
                RaisePropertyChanged(propertyName);
            }
        }

        protected void RaisePropertyChanged(
            [CallerMemberName] string propertyName = null)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
