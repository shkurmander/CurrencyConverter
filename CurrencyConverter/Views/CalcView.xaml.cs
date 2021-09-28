using CurrencyConverter.Models;
using CurrencyConverter.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace CurrencyConverter.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class CalcView : Page
    {
        private readonly CalcViewModel _vm = new CalcViewModel();
        public CalcView()
        {
            this.InitializeComponent();
            
        }    


    }
}
