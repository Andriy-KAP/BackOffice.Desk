﻿using BackOffice.Desk.UI.Common.ViewModel.ViewModels;
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
        public ICommand OrdersCommand { get; set; }
        public RootViewModel()
        {
            CurrentView = new HomeViewModel();

            HomeCommand = new RelayCommand(ExecuteHomeCommand);
            ClientsCommand = new RelayCommand(ExecuteClientsCommand);
            OrdersCommand = new RelayCommand(ExecuteOrdersCommand);
        }

        private void ExecuteHomeCommand(object obj)
        {
            CurrentView = new HomeViewModel();
        }
        private void ExecuteClientsCommand(object obj)
        {
            CurrentView = new ClientsViewModel();
        }
        private void ExecuteOrdersCommand(object obj)
        {
            CurrentView = new OrdersViewModel();
        }
    }
}
