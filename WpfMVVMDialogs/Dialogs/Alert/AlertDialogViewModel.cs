using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfMVVMDialogs.Dialogs.Service;
using WpfMVVMDialogs.Utilities;

namespace WpfMVVMDialogs.Dialogs.Alert
{
    public class AlertDialogViewModel : DialogViewModelBase<DialogResult>
    {
        public ICommand OKCommand { get; private set; }
        public AlertDialogViewModel()
        {
            OKCommand = new RelayCommand<DialogWindow>(OK);
        }

        private void OK(object obj)
        {
            
        }
    }
}
