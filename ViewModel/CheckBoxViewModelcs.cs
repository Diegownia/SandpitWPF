using SandpitWPF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandpitWPF.ViewModel
{
    public class CheckBoxViewModelcs : BaseViewModel, ICheckBoxViewModelcs
    {
        private bool _divideBy10;// = false;
        private bool _divideBy100;// = false;
        private bool _divideBy1000;// = false;
        private bool _divideBy10000;// = false;



        public bool DivideBy10
        {
            get => _divideBy10;
            set
            {
                _divideBy10 = value;
                NotifyPropertyChanged(nameof(DivideBy10));
            }
        }

        public bool DivideBy100
        {
            get => _divideBy100;
            set
            {
                _divideBy100 = value;
                NotifyPropertyChanged(nameof(DivideBy100));
            }
        }

        public bool DivideBy1000
        {
            get => _divideBy1000;
            set
            {
                _divideBy1000 = value;
                NotifyPropertyChanged(nameof(DivideBy1000));
            }
        }
        public bool DivideBy10000
        {
            get => _divideBy10000;
            set
            {
                _divideBy10000 = value;
                NotifyPropertyChanged(nameof(DivideBy10000));
            }
        }
    }



}
