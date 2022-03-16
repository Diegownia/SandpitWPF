using SandpitWPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandpitWPF.ViewModel
{
    public class BasicDataBindingViewModel : BaseViewModel
    {
        private readonly BasicDataBindingService _basicDataBindingService;
        private double _input;

        public BasicDataBindingViewModel()
        {
            _basicDataBindingService = new BasicDataBindingService();
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
