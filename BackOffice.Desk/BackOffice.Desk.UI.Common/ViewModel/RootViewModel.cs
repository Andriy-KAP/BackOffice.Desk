using BackOffice.Desk.UI.Common.ViewModel.Sections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice.Desk.UI.Common.ViewModel
{
    public class RootViewModel
    {
        public ClientsViewModel Clients { get; private set; }

        public RootViewModel()
        {
            this.Clients = new ClientsViewModel();
        }
    }
}
