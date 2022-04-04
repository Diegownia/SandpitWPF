using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandpitWPF.Model
{
    public class ListBoxItems
    {
        private readonly IList<string> _listBoxItems;

        public ListBoxItems()
        {

            _listBoxItems = new List<string> { "Tea", "Coffee", "Milk" };

        }
        public IList<string> ListBoxItem => _listBoxItems;








    }
}
