using SandpitWPF.Interfaces;
using SandpitWPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandpitWPF.ViewModel
{
    public class BasicDataBindingViewModel : BaseViewModel, IBasicDataBindingViewModel
    {
        private readonly IBasicDataBindingService _basicDataBindingService;
        private double _input;

        public BasicDataBindingViewModel(IBasicDataBindingService basicDataBindingService)
        {
            _basicDataBindingService = basicDataBindingService;
        }


        public double Input
        {
            get => _input;
            set
            {
                _input = value;
                NotifyPropertyChanged(nameof(Input));
                NotifyPropertyChanged(nameof(Output));
            }
        }

        public double Output => _basicDataBindingService.Divide(_input);

    }
}
