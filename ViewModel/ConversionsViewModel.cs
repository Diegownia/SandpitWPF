using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandpitWPF.ViewModel
{
    public class ConversionsViewModel : BaseViewModel, IConversionsViewModel
    {
        public IList<string> Index { get; }
        private string _selectedItem;

        public ConversionsViewModel()
        {
            Index = new List<string> { "First", "Second", "Third" };

        }

        public string SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                NotifyPropertyChanged(nameof(SelectedItem));
            }
        }
    }
}
