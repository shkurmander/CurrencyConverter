using CurrencyConverter.Models;
using System.Collections.ObjectModel;

namespace CurrencyConverter.ViewModels
{
    public class ValutesViewModel
    {
        private ValuteRepository _valuteRepository { get; }

        public ObservableCollection<Valute> Valutes 
        {
            get => new ObservableCollection<Valute>(_valuteRepository.GetAll());
        }

        public ValutesViewModel()
        {
            _valuteRepository = new ValuteRepository();
        }

    }
}
