using System.Collections.Generic;

namespace SandpitWPF.ViewModel
{
    public interface IConversionsViewModel
    {
        IList<string> Index { get; }
        string SelectedItem { get; set; }
    }
}