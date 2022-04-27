using SandpitWPF.Interfaces;
using SandpitWPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandpitWPF.ViewModel
{
    public class ConversionsViewModel : BaseViewModel, IConversionsViewModel
    {
        //public IConversionsDataService Index;
        public  IList<string> Index { get; private set; }
        public IConversionsDataService DataService;
        private string _selectedItem;

        public ConversionsViewModel(IConversionsDataService dataService)
        {
            //Index = index;
            DataService = dataService;
            //Index = DataService.GetData();

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

        public void Load()
        {
            Index = DataService.GetData();
            NotifyPropertyChanged(nameof(Index));
        }
    }
}
