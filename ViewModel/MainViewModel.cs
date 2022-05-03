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
        public IUserDialogViewModel UserViewModel { get; }
        public INavigationService NavigationService { get; set; }
        public IDialogService DialogService { get; set; }
        private bool? _userAddDialogVisible = false;
        private bool? _moreUserButtonsVisible = false;
        
        //private INavigationService _navigationService { get; set; }


        public MainViewModel(IConversionsViewModel conversionsViewModel, IBasicDataBindingViewModel basicDataBindingViewModel,
            IBasicConversionViewModel basicConversionViewModel, IUserDialogViewModel userViewModel, INavigationService navigationService, IDialogService dialogService)
        {
            NavigationService = navigationService;
            ConversionsViewModel = conversionsViewModel;
            BasicDataBindingViewModel =  basicDataBindingViewModel;
            BasicConversionViewModel =  basicConversionViewModel;
            UserViewModel =  userViewModel;
            DialogService = dialogService;
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
        public void OpenWindow()
        {
            NavigationService.OpenWindow();
        }

        public bool? UserAddDialogVisible
        {
            get { return _userAddDialogVisible; }
            set
            {
                _userAddDialogVisible = value;
                NotifyPropertyChanged(nameof(UserAddDialogVisible));
            }
        }



        public void OnAddUsersClick()
        {
            _userAddDialogVisible = DialogService.ShowDialog(UserViewModel);
            if (_userAddDialogVisible != true)
            {
                return;
            }
            //todo adda data Service to save;
        }

        public bool? MoreUserButtonsVisible
        {
            get { return _moreUserButtonsVisible; }
            set
            {
                _moreUserButtonsVisible = value;
                NotifyPropertyChanged(nameof(MoreUserButtonsVisible));
            }
        }


        public void OnDisplayMoreButtons()
        {
            _moreUserButtonsVisible = DialogService2.ShowDialog(Dialog2ViewModel);
                //Finish At home?
        }

        //ListBoxExample.ItemSource = listBoxItems;
    }
}
