using SandpitWPF.Interfaces;
using SandpitWPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandpitWPF.ViewModel
{
    public class BasicConversionViewModel : BaseViewModel, IBasicConversionViewModel
    {
        private readonly IBasicConversionService _basicConversionService;
        public ICheckBoxViewModelcs CheckBoxViewModelcs { get; }

        private double _metersInput;
        private double _kilogramsInput;
        private double _kilometersInput;

        public BasicConversionViewModel(IBasicConversionService basicConversionService, ICheckBoxViewModelcs checkBoxViewModelcs)
        {
            _basicConversionService = basicConversionService;
            CheckBoxViewModelcs = checkBoxViewModelcs;
            checkBoxViewModelcs.PropertyChanged += CheckBoxViewModelcs_PropertyChanged;
        }

        private void CheckBoxViewModelcs_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(CheckBoxViewModelcs.DivideBy10) ||
                e.PropertyName == nameof(CheckBoxViewModelcs.DivideBy100) ||
                e.PropertyName == nameof(CheckBoxViewModelcs.DivideBy1000) ||
                e.PropertyName == nameof(CheckBoxViewModelcs.DivideBy10000))
            {
                NotifyPropertyChanged(nameof(MetersOutput));
                NotifyPropertyChanged(nameof(KilogramsOutput));
                NotifyPropertyChanged(nameof(KilometersOutput));
            }
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

        public string MetersOutput
        {
            get
            {
                if (CheckBoxViewModelcs.DivideBy10 == true)
                {
                    return (_basicConversionService.MeterstoFeet(_metersInput) / 10).ToString("E04");
                }
                else if (CheckBoxViewModelcs.DivideBy100 == true)
                {
                    return (_basicConversionService.MeterstoFeet(_metersInput) / 100).ToString("E04");
                }
                else if (CheckBoxViewModelcs.DivideBy1000 == true)
                {
                    return (_basicConversionService.MeterstoFeet(_metersInput) / 1000).ToString("E04");
                }
                else if (CheckBoxViewModelcs.DivideBy10000 == true)
                {
                    return (_basicConversionService.MeterstoFeet(_metersInput) / 10000).ToString("E04");
                }

                return _basicConversionService.MeterstoFeet(_metersInput).ToString("E04");
            }
        }
        //public double KilogramsOutput => _basicConversionService.KilogramsToPounds(_kilogramsInput);
        public string KilogramsOutput
        {
            get
            {
                if (CheckBoxViewModelcs.DivideBy10 == true)
                {
                    return (_basicConversionService.KilogramsToPounds(_kilogramsInput) / 10).ToString("E04");
                }
                else if (CheckBoxViewModelcs.DivideBy100 == true)
                {
                    return (_basicConversionService.KilogramsToPounds(_kilogramsInput) / 100).ToString("E04");
                }
                else if (CheckBoxViewModelcs.DivideBy1000 == true)
                {
                    return (_basicConversionService.KilogramsToPounds(_kilogramsInput) / 1000).ToString("E04");
                }
                else if (CheckBoxViewModelcs.DivideBy10000 == true)
                {
                    return (_basicConversionService.KilogramsToPounds(_kilogramsInput) / 10000).ToString("E04");
                }
                return _basicConversionService.KilogramsToPounds(_kilogramsInput).ToString("E04");
            }
        }


        public double KilometersOutput
        {
            get
            {
                if (CheckBoxViewModelcs.DivideBy10 == true)
                {
                    return _basicConversionService.KilometersPerHourToMetersPerSecond(KilometersInput) / 10;
                }
                else if (CheckBoxViewModelcs.DivideBy100 == true)
                {
                    return _basicConversionService.KilometersPerHourToMetersPerSecond(KilometersInput) / 100;
                }
                else if (CheckBoxViewModelcs.DivideBy1000 == true)
                {
                    return _basicConversionService.KilometersPerHourToMetersPerSecond(KilometersInput) / 1000;
                }
                else if (CheckBoxViewModelcs.DivideBy10000 == true)
                {
                    return _basicConversionService.KilometersPerHourToMetersPerSecond(KilometersInput) / 10000;
                }
                return _basicConversionService.KilometersPerHourToMetersPerSecond(_kilometersInput);
            }
        }

        //public double KilometersOutput => _basicConversionService.KilometersPerHourToMetersPerSecond(_kilometersInput);
    }
}
