using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.ViewModels
{
    public class CalcViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string CharCode1 {get; set; }
        public string CharCode2 { get; set; }
        public bool ChangeButton1 { get; set; }
        public bool ChangeButton2 { get; set; }

        public CalcViewModel()
        {
            CharCode1 = "RUB";
            CharCode2 = "USD";
            ChangeButton1 = false;
            ChangeButton2 = false;
        }



    }
}
