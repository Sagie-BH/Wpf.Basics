using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfRelayCommand.ViewModel
{
    public class MessageViewModel
    {
        public ObservableCollection<string> MyMessages { get; private set; }
        public RelayCommand MessageBoxCommand { get; private set; }

        public RelayCommand ConsoleLogCommand { get; private set; }
        public MessageViewModel()
        {
            MyMessages = new ObservableCollection<string>()
            {
                "Hello",
                "World",
                "Buya",
                "hakuna",
                "Matata",
                "Camel"
            };
            MessageBoxCommand = new RelayCommand(DisplayMessageBox, MessageBoxCanUse);
            ConsoleLogCommand = new RelayCommand(DisplayInConsole, ConsoleCanUse);
        }
        public void DisplayMessageBox(object message)
        {
            MessageBox.Show((string)message);
        }
        public void DisplayInConsole(object message)
        {
            Console.WriteLine((string)message);
        }
        public bool MessageBoxCanUse(object message)
        {
            if ((string)message == "Camel")
                return false;

            return true;
        }
        public bool ConsoleCanUse(object message)
        {
            if ((string)message == "World")
                return false;

            return true;
        }
    }
}
