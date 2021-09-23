using CurrencyConverter.Model;
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
        private ValuteRepository _valuteRepository;
        public event PropertyChangedEventHandler PropertyChanged;
       
        public bool ChangeButton1 { get; set; }
        public bool ChangeButton2 { get; set; }
        public Valute Valute1 { get; set; }
        public Valute Valute2 { get; set; }

        public CalcViewModel()
        {
            _valuteRepository = new ValuteRepository();
            Valute1 = _valuteRepository.GetByCharCode("RUB");
            Valute2 = _valuteRepository.GetByCharCode("USD");
            ChangeButton1 = false;
            ChangeButton2 = false;
        }
        


    }
}
