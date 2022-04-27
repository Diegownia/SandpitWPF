using SandpitWPF.Interfaces;
using SandpitWPF.Model;
using SandpitWPF.Services;
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
        public IConversionsViewModel ConversionsViewModel { get; }
        public IBasicDataBindingViewModel BasicDataBindingViewModel { get; }
        public IBasicConversionViewModel BasicConversionViewModel { get; }
        public IUserViewModel UserViewModel { get; }
        //private INavigationService _navigationService { get; set; }

        public MainViewModel(IConversionsViewModel conversionsViewModel, IBasicDataBindingViewModel basicDataBindingViewModel,
            IBasicConversionViewModel basicConversionViewModel, IUserViewModel userViewModel)
        {
            ConversionsViewModel = conversionsViewModel;
            BasicDataBindingViewModel =  basicDataBindingViewModel;
            BasicConversionViewModel =  basicConversionViewModel;
            UserViewModel =  userViewModel;
            //_navigationService = new NavigationService();

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

        public void Load()
        {
            ConversionsViewModel.Load();
        }

        //ListBoxExample.ItemSource = listBoxItems;
    }
}
