using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice.Desk.UI.Common.ViewModel.Item
{
    public class ProductItemViewModel
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int TotalCount { get; set; }
        public int Reserved { get; set; }
        public int Free { get; set; }
    }
}
