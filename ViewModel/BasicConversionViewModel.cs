using SandpitWPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandpitWPF.ViewModel
{
    public class BasicConversionViewModel : BaseViewModel
    {
        private readonly BasicConversionService _basicConversionService;

        private double _metersInput;
        private double _kilogramsInput;
        private double _kilometersInput;

        public BasicConversionViewModel()
        {
            _basicConversionService = new BasicConversionService();
        }

        public double MetersInput
        {
            get => _metersInput;
            set
            {
                _metersInput = value;
                NotifyPropertyChanged(nameof(MetersInput));
                NotifyPropertyChanged(nameof(MetersOutput));
            }
        }

        public double KilogramsInput
        {
            get => _kilogramsInput;
            set
            {
                _kilogramsInput = value;
                NotifyPropertyChanged(nameof(KilogramsInput));
                NotifyPropertyChanged(nameof(KilogramsOutput));
            }

        }

        public double KilometersInput
        {
            get => _kilometersInput;
            set
            {
                _kilometersInput = value;
                NotifyPropertyChanged(nameof(KilometersInput));
                NotifyPropertyChanged(nameof(KilometersOutput));
            }

        }

        public double MetersOutput => _basicConversionService.MeterstoFeet(_metersInput);
        public double KilogramsOutput => _basicConversionService.KilogramsToPounds(_kilogramsInput);
        public double KilometersOutput => _basicConversionService.KilometersPerHourToMetersPerSecond(_kilometersInput);
    }
}
