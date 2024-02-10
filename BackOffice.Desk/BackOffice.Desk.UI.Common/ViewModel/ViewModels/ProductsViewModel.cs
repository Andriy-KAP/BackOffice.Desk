using BackOffice.Desk.UI.Common.ViewModel.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice.Desk.UI.Common.ViewModel.ViewModels
{
    public sealed class ProductsViewModel: ViewModelBase<ProductItemViewModel>
    {
        public ProductsViewModel()
        {
            Items = new ObservableCollection<ProductItemViewModel>()
            {
                new ProductItemViewModel() { Id=1, Model="%fgssjkfdh", Type="Winter", TotalCount=10, Reserved = 4, Free=6},
                new ProductItemViewModel() { Id=2, Model="asdasd", Type="Winter", TotalCount=10, Reserved = 4, Free=6},
                new ProductItemViewModel() { Id=3, Model="GHBBNMB", Type="Winter", TotalCount=10, Reserved = 4, Free=6},
                new ProductItemViewModel() { Id=4, Model="ioertuoi", Type="Winter", TotalCount=10, Reserved = 4, Free=6},
                new ProductItemViewModel() { Id=5, Model="%fgssjkfdh", Type="Winter", TotalCount=10, Reserved = 4, Free=6},
                new ProductItemViewModel() { Id=6, Model="%fgssjkfdh", Type="Winter", TotalCount=10, Reserved = 4, Free=6},
                new ProductItemViewModel() { Id=7, Model="%fgssjkfdh", Type="Winter", TotalCount=10, Reserved = 4, Free=6},
                new ProductItemViewModel() { Id=8, Model="%fgssjkfdh", Type="Winter", TotalCount=10, Reserved = 4, Free=6},
                new ProductItemViewModel() { Id=9, Model="%fgssjkfdh", Type="Winter", TotalCount=10, Reserved = 4, Free=6},
                new ProductItemViewModel() { Id=10, Model="%fgssjkfdh", Type="Winter", TotalCount=10, Reserved = 4, Free=6},
                new ProductItemViewModel() { Id=11, Model="%fgssjkfdh", Type="Winter", TotalCount=10, Reserved = 4, Free=6},
                new ProductItemViewModel() { Id=12, Model="%fgssjkfdh", Type="Winter", TotalCount=10, Reserved = 4, Free=6},
                new ProductItemViewModel() { Id=13, Model="%fgssjkfdh", Type="Summer", TotalCount=10, Reserved = 4, Free=6},
                new ProductItemViewModel() { Id=14, Model="%fgssjkfdh", Type="Winter", TotalCount=10, Reserved = 4, Free=6},
                new ProductItemViewModel() { Id=15, Model="%fgssjkfdh", Type="Winter", TotalCount=10, Reserved = 4, Free=6},
                new ProductItemViewModel() { Id=16, Model="%fgssjkfdh", Type="Winter", TotalCount=10, Reserved = 4, Free=6},
            };
        }
    }
}
