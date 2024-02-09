using BackOffice.Desk.UI.Common.ViewModel.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice.Desk.UI.Common.ViewModel.ViewModels
{
    public sealed class ClientsViewModel : ViewModelBase<ClientItemViewModel>
    {
        public ClientsViewModel()
        {
            Items = new ObservableCollection<ClientItemViewModel>() 
            {
                new ClientItemViewModel(){ Name="Alex", PhoneNumber="+380667832865"},
                new ClientItemViewModel(){ Name="Oleg", PhoneNumber="+380951112234"},
                new ClientItemViewModel(){ Name="Andrii", PhoneNumber="+380667832865"},
            };
        }
    }
}
