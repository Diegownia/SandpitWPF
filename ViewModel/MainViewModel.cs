using SandpitWPF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandpitWPF.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private IList<string> _listBoxItems;
        public ConversionsViewModel ConversionsViewModel { get; }
        public BasicDataBindingViewModel BasicDataBindingViewModel { get; }
        public BasicConversionViewModel BasicConversionViewModel { get; }

        public MainViewModel()
        {
            ConversionsViewModel = new ConversionsViewModel();
            BasicDataBindingViewModel = new BasicDataBindingViewModel();
            BasicConversionViewModel = new BasicConversionViewModel();

        }

        public IList<string> ListBoxItems
        {
            get => _listBoxItems;
            set
            {
                _listBoxItems = value;
                NotifyPropertyChanged(nameof(ListBoxItems));
            }
        }

        //ListBoxExample.ItemSource = listBoxItems;
    }
}
