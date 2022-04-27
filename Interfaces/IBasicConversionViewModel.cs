using SandpitWPF.ViewModel;

namespace SandpitWPF.Interfaces
{
    public interface IBasicConversionViewModel
    {
        ICheckBoxViewModelcs CheckBoxViewModelcs { get; }
        double KilogramsInput { get; set; }
        string KilogramsOutput { get; }
        double KilometersInput { get; set; }
        double KilometersOutput { get; }
        double MetersInput { get; set; }
        string MetersOutput { get; }
    }
}