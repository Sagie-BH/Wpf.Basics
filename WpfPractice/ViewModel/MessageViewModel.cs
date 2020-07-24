using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfPractice.ViewModel.Commands;

namespace WpfPractice.ViewModel
{
    public class MessageViewModel
    {
        public string MessageText { get; set; }
        public MessageCommand DisplayMessageCommand { get; set; }
        public MessageViewModel()
        {
            DisplayMessageCommand = new MessageCommand(DisplayMessage);
        }
        public void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
