using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfMVVMDialogs.Utilities;

namespace WpfMVVMDialogs.ViewModels
{
    public class MainWindowViewModel
    {
        public ICommand YesNoCommand { get; private set; }
        public ICommand AlertCommand { get; private set; }

        public MainWindowViewModel()
        {
            YesNoCommand = new RelayCommand(YesNo);
            AlertCommand = new RelayCommand(Alert);
        }

        private void Alert(object obj)
        {
            throw new NotImplementedException();
        }

        private void YesNo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
