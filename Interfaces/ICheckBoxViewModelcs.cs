using System.ComponentModel;

namespace SandpitWPF.Interfaces
{
    public interface ICheckBoxViewModelcs : INotifyPropertyChanged
    {
        bool DivideBy10 { get; set; }
        bool DivideBy100 { get; set; }
        bool DivideBy1000 { get; set; }
        bool DivideBy10000 { get; set; }
    }
}