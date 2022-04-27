using System.Collections.Generic;

namespace SandpitWPF.Interfaces
{
    public interface IConversionsViewModel
    {
        IList<string> Index { get; }
        string SelectedItem { get; set; }
    }
}