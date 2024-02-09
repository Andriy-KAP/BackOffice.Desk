using BackOffice.Desk.UI.Common.ViewModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.Common.Util;

namespace BackOffice.Desk.UI.Common.ViewModel
{
    public class RootViewModel : ViewModelBase
    {
        private ViewModelBase currentViewModel;

        public ViewModelBase CurrentView
        {
            get { return currentViewModel; }
            set 
            { 
                currentViewModel = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand ClientsCommand { get; set; }

        public RootViewModel()
        {
            HomeCommand = new RelayCommand(Home);
            ClientsCommand = new RelayCommand(Clients);
        }

        private void Home(object obj)
        {
            CurrentView = new HomeViewModel();
        }

        private void Clients(object obj)
        {
            CurrentView = new ClientsViewModel();
        }
    }
}
