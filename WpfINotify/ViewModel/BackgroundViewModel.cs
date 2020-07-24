using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfINotify.ViewModel
{
    public class BackgroundViewModel : ObservableObject
    {
        private Brush _color;
        public Brush Color
        {
            get
            {
                if (_color == null)
                    return Brushes.Red;
                return _color;
            }
            set
            {
                _color = value;
                onPropertyChanged("Color");
            }
        }
    }
}
