using CurrencyConverter.Models;
using System.ComponentModel;

namespace CurrencyConverter.ViewModels
{
    internal class CalcViewModel : ViewModelBase
    {
        private ValuteRepository _valuteRepository;
       
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
