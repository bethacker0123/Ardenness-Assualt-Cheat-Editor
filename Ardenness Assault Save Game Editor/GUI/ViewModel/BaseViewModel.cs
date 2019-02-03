using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Ardenness_Assault_Save_Game_Editor.GUI.ViewModel
{
    internal class BaseViewModel : INotifyPropertyChanged

    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual void OnClosing(object sender, CancelEventArgs e)
        {
        }
    }
}

