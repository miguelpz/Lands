

namespace Lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;

    using Models;
    using Lands.Views;
    using System.Linq;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class BorderItemViewModel:Border
    {
        #region Commands
        public ICommand SelectLandCommand
        {
            get
            {
                return new RelayCommand(SelectLand);
            }
        }

        private async void SelectLand()
        {
            var land = MainViewModel.GetInstance().LandsList.Where(l => l.Name == this.Name).FirstOrDefault();
            MainViewModel.GetInstance().Land = new LandViewModel(land);
            await Application.Current.MainPage.Navigation.PushAsync(new LandTabbedPage());

        }
        #endregion

    }
}
