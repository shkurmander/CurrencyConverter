using CurrencyConverter.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
