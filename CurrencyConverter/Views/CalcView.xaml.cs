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
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Parameter != null)
            {
                if (_vm.ChangeButton1)
                {
                    _vm.Valute1 = e.Parameter as Valute;
                    _vm.ChangeButton1 = false;
                }
                if(_vm.ChangeButton2)
                {
                    _vm.Valute2 = e.Parameter as Valute;
                    _vm.ChangeButton2 = false;
                }

            }
        }
        private void TextBlockChange1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            _vm.ChangeButton1 = true;
            Frame.Navigate(typeof(ValutesView));
        }
        private void TextBlockChange2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            _vm.ChangeButton2 = true;
            Frame.Navigate(typeof(ValutesView));
        }
        


    }
}
